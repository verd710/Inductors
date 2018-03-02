using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Inductors
{
    public partial class Main : Form
    {
        int sectionNum = 0;
        bool same = true;
        double diameter = 0;
        double sectionWidth = 0;
        double betweenSections = 0;
        int[] coilNum;
        String wireType = "";
        double wireDiameter = 0;
        double maxWireDiameter = 0;

        String[] FirstLineOfFile;
        String[] SecondLineOfFile;


        String[] NFirstLineOfFile;
        String[] NSecondLineOfFile;

        List<String> wireTypesAvailable;

        double kn = 1.09;          //коэффициент неплотности намотки
        double L = 0;


        public Main()
        {
            InitializeComponent();

            //initialization of the radio button
            radioButton_same.Checked = same;

            UpdateWireTypes();
            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        double MutualInduction(double A, double B, double a)
        {
            double r2r1 = Math.Sqrt((Math.Pow((1 - a / A), 2) + Math.Pow(B, 2) / Math.Pow(A, 2)) / (Math.Pow((1 + a / A), 2) + Math.Pow(B, 2) / Math.Pow(A, 2)));

            int i;
            for (i = 0; i < NFirstLineOfFile.Length && r2r1 > Convert.ToDouble(NFirstLineOfFile[i]); i++) ;

            double N = 0;
            if (i != 0)
                N = Convert.ToDouble(NSecondLineOfFile[i - 1]) - ((Convert.ToDouble(NSecondLineOfFile[i - 1]) - Convert.ToDouble(NSecondLineOfFile[i])) * (r2r1 - Convert.ToDouble(NFirstLineOfFile[i - 1])) / (Convert.ToDouble(NFirstLineOfFile[i]) - Convert.ToDouble(NFirstLineOfFile[i - 1])));

            return N * Math.Sqrt((A / 10) * (a / 10));         //с переводом в сантиметры

        }

        double InductionBetween(double a, double D2, int step)
        {
            double A, B;
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //для точек 0-1
            double M01;
            A = a;
            B = (sectionWidth + betweenSections) * step;        //step - количество секций между между секциями + 1
            M01 = MutualInduction(A, B, a);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //для точек 0-2
            double M02;
            A = D2 / 2;
            B = (sectionWidth + betweenSections) * step;
            M02 = MutualInduction(A, B, a);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //для точек 0-3
            double M03;
            A = diameter / 2;
            B = (sectionWidth + betweenSections) * step;
            M03 = MutualInduction(A, B, a);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //для точек 0-4
            double M04;
            A = a;
            B = (sectionWidth / 2 + betweenSections + sectionWidth) * step;
            M04 = MutualInduction(A, B, a);


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //для точек 0-5
            double M05;
            A = a;
            B = (sectionWidth / 2 + betweenSections) * step;
            M05 = MutualInduction(A, B, a);

            return (M02 + M03 + M04 + M05 - M01);
        }

        double InductionBetweenSections(double a, double D2, int step, int n1, int n2)  //a - средний радиус, D2 - полный диаметр, n1/n2 - число витков первой/второй секции
        {
            double M;

            if (same)
                M = Math.Pow(n1, 2) * InductionBetween(a, D2, step) / 3;
            else
            {
                //размеры намотки второй секции
                double _C = n2 * Math.Pow((kn * maxWireDiameter), 2) / sectionWidth;
                double _D2 = diameter + 2 * _C;
                double _D = (_D2 + diameter) / 2;
                double _a = _D / 2;                    //средний радиус секции

                M = n1 * n2 * (InductionBetween(a, D2, step) + InductionBetween(_a, _D2, step)) / 6;
            }

            return M;

        }
        
        bool Solve()
        {
            //чтение значений N из таблицы один раз во время исполнения программы
            if (NFirstLineOfFile == null)
                if (!ReadFromFile("N.txt", ref NFirstLineOfFile, ref NSecondLineOfFile, false))
                    return false;

            if (same)
            {

                //размеры намотки
                double C = coilNum[0] * Math.Pow((kn * maxWireDiameter), 2) / sectionWidth;
                double D2 = diameter + 2 * C;
                double D = (D2 + diameter) / 2;
                double a = D / 2;                    //средний радиус секции

                //индуктивность одной секции
                double L1 = 0.0025 * Math.PI * Math.Pow(coilNum[0], 2) * Math.Pow(D, 2) / (3 * D + 9 * sectionWidth + 10 * C);

                //расчетная индуктивность дросселя

                L = sectionNum * L1;

                //взаимоиндукция между секциями

                for (int i = 1; i < sectionNum; i++)
                {
                    double M = InductionBetweenSections(a, D2, i, coilNum[0], 0);
                    L += 2 * M * (sectionNum - i);
                }


            }

            else
            {

                L = 0;

                for (int i = 0; i < sectionNum; i++)
                {

                    //размеры намотки
                    double C = coilNum[i] * Math.Pow((kn * maxWireDiameter), 2) / sectionWidth;
                    double D2 = diameter + 2 * C;
                    double D = (D2 + diameter) / 2;
                    double a = D / 2;                    //средний радиус секции

                    //индуктивность одной секции
                    double Ln = 0.0025 * Math.PI * Math.Pow(coilNum[i], 2) * Math.Pow(D, 2) / (3 * D + 9 * sectionWidth + 10 * C);

                    L += Ln;

                    for (int j = i + 1; j < sectionNum; j++)
                    {
                        //взаимоиндукция между секциями

                        double M = InductionBetweenSections(a, D2, j - i, coilNum[i], coilNum[j]);
                        L += 2 * M;

                    }

                }


            }


            return true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void Reset()
        {
            //resetting values

            sectionNum = 0;
            same = true;
            diameter = 0;
            sectionWidth = 0;
            betweenSections = 0;
            wireType = "";
            wireDiameter = 0;
            maxWireDiameter = 0;
            L = 0;

            if (coilNum != null)
                Array.Clear(coilNum, 0, coilNum.Length);

            if (FirstLineOfFile != null)
                Array.Clear(FirstLineOfFile, 0, FirstLineOfFile.Length);

            if (SecondLineOfFile != null)
                Array.Clear(SecondLineOfFile, 0, SecondLineOfFile.Length);



            //resetting the window

            textBox_section_num.Text = "";
            radioButton_same.Checked = true;
            textBox_diameter.Text = "";
            textBox_section_width.Text = "";
            textBox_between_sections.Text = "";
            comboBox_wire_type.SelectedIndex = -1;
            comboBox_wire_diameter.SelectedIndex = -1;
            comboBox_wire_diameter.Items.Clear();
            dataGridView_num.Rows.Clear();
            dataGridView_num.Columns.Clear();
            label_result.Text = "";
            panelDraw.Invalidate();

        }

        bool ReadFromFile(String fileName, ref String[] line1, ref String[] line2, bool readKn)
        {
            String text = "";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(fileName))
                {
                    // Read the stream to a string
                    text = sr.ReadToEnd();

                    String[] Lines = text.Split(new char[]{'\n'}, System.StringSplitOptions.RemoveEmptyEntries);

                    int i = 0;

                    if (readKn)
                    {
                        double newkn = Convert.ToDouble(Lines[0]);
                        if (newkn < 1 || newkn > 2)
                            throw new Exception("Значение коэффициента неплотности намотки указано неверно");

                        kn = newkn;
                        i++;
                    }

                    line1 = new String[Lines.Length - i];
                    line2 = new String[Lines.Length - i];

                    for (int j = 0; i < Lines.Length; i++, j++)
                    {
                        String[] splitLine = Lines[i].Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                        line1[j] = splitLine[0];
                        line2[j] = splitLine[1];

                    }

                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be read: " + ex.Message);
                return false;

            }


        }

        public static List<String> ReadWireTypes()
        {
            String text = "";
            String fileName = "WIRETYPES.txt";
            List<String> list;
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
                {
                    // Read the stream to a string
                    text = sr.ReadToEnd();

                    String[] Lines = text.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries); 

                    list = new List<String>(Lines);

                    return list;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be read: " + ex.Message);
                list = new List<String>();
                return list;

            }
            
        }

        void UpdateWireTypes()
        {
            if(wireTypesAvailable != null)
                wireTypesAvailable.Clear();
            
            wireTypesAvailable = ReadWireTypes();

            comboBox_wire_type.Items.Clear();
            foreach (String wire in wireTypesAvailable)
                comboBox_wire_type.Items.Add(wire);

            comboBox_wire_type.SelectedIndex = comboBox_wire_type.Items.IndexOf(wireType);
        }

        //a method that parses a special format of wire diameter like: 0,1x14
        double ParseWireDiameter(string text)
        {

            int index = text.IndexOf('x');
            return Convert.ToDouble(text.Substring(0, index)) * Convert.ToDouble(text.Substring(index + 1, text.Length - 1 - index));

        }

        void UpdateGridView()
        {
            dataGridView_num.Rows.Clear();
            dataGridView_num.Columns.Clear();


            dataGridView_num.Columns.Add("columnName", "");

            same = radioButton_same.Checked;

            //if the section are the same, add one row

            if (same)
            {
                dataGridView_num.Rows.Add();
            }
            else
            {
                if (sectionNum != 0)
                    dataGridView_num.Rows.Add(sectionNum);
            }

            //adding row headers
            foreach (DataGridViewRow row in dataGridView_num.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }


        }

        //reads data from the window and checks for input errors
        bool ReadAndCheck(ref String errorText)
        {
            bool error = false;
            //check if the section number is entered

            if (sectionNum == 0)
            {
                error = true;
                errorText += "\nЧисло секций";
            }

            else
            {
                //check coil number input format and save

                //if same - coil number array consists of 1 element

                if (same)
                    coilNum = new int[1];
                else
                    coilNum = new int[sectionNum];

                bool coilNumError = false;

                foreach (DataGridViewRow row in dataGridView_num.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!int.TryParse(Convert.ToString(cell.Value), out coilNum[cell.RowIndex]) || coilNum[cell.RowIndex] <= 0)
                        {

                            if (!coilNumError)
                                errorText += "\nЧисло витков в секциях";
                            error = true;
                            coilNumError = true;
                        }
                    }
                }
            }

            //check diameter input format and save

            if (!double.TryParse(textBox_diameter.Text, out diameter) || diameter <= 0)
            {
                error = true;
                errorText += "\nДиаметр каркаса";
            }
            //check width input format and save

            if (!double.TryParse(textBox_section_width.Text, out sectionWidth) || sectionWidth <= 0)
            {
                error = true;
                errorText += "\nШирина секций";
            }
            //check between sections input format and save

            if (!double.TryParse(textBox_between_sections.Text, out betweenSections) || betweenSections <= 0)
                if (sectionNum != 1)     //for 1 section, between sections is not needed
                {
                    error = true;
                    errorText += "\nРасстояние между секциями";
                }

            if (wireType == "")
            {
                error = true;
                errorText += "\nТип провода";
            }
            //check wire diameter input format

            if (wireDiameter == 0)
            {
                error = true;
                errorText += "\nДиаметр провода по меди";
            }
            return error;


        }

        int MaxCoilNum()
        {
            int max = coilNum[0];
            if (!same)
            {
                foreach (int coil in coilNum)
                    if (coil > max)
                        max = coil; 
            }

            return max;
        }

        double MaxSectionDiameter()
        {
            double C = MaxCoilNum() * Math.Pow((kn * maxWireDiameter), 2) / sectionWidth;
            double D2 = diameter + 2 * C;

            return D2;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void textBox_section_num_TextChanged(object sender, EventArgs e)
        {
            label_sectionNumError.Text = "";
            label_result.Text = "";
            //read number of sections

            String sectionNumText = textBox_section_num.Text;

            //check the input for words and negative numbers

            if (int.TryParse(sectionNumText, out sectionNum) && sectionNum > 0 && sectionNum <= 20)
            {
                if (sectionNum > 15)
                    label_sectionNumError.Text = "А не замучаетесь ли вы мотать?";

                else if (sectionNum > 10)
                    label_sectionNumError.Text = "А вы уверены, что вам хватит длины каркаса?";

                UpdateGridView();
            }


            else
            {
                if (sectionNum > 20)
                {
                    label_sectionNumError.Text = "Ну вы меня умотали!";
                    label_result.Text = "Не могу!";
                }

                sectionNum = 0;
            }

            if (sectionNum == 1)
            {
                textBox_between_sections.Enabled = false;
                textBox_between_sections.Text = "";
                betweenSections = 0;
            }
            else
                textBox_between_sections.Enabled = true;



        }

        private void radioButton_different_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGridView();

        }

        private void comboBox_wire_type_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //reset wire diameter window
            comboBox_wire_diameter.SelectedIndex = -1;
            comboBox_wire_diameter.Items.Clear();

            //check wire type input format and save

            wireType = comboBox_wire_type.Text;


            //read wire diameter from file 


            string fileName = wireType + ".txt";


            if (ReadFromFile(fileName, ref FirstLineOfFile, ref SecondLineOfFile, true))
                //fill the combobox
                for (int i = 0; i < FirstLineOfFile.Length; i++)
                    comboBox_wire_diameter.Items.Add(FirstLineOfFile[i]);


            wireDiameter = 0;
            maxWireDiameter = 0;
        }

        private void comboBox_wire_diameter_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string wireDiameterText = comboBox_wire_diameter.Text;
            maxWireDiameter = 0;

            //check wire diameter input format and save
            if (!double.TryParse(comboBox_wire_diameter.Text, out wireDiameter))
                wireDiameter = ParseWireDiameter(comboBox_wire_diameter.Text);

            //get maxWireDiameter from saved lines of the file 

            for (int i = 0; i < FirstLineOfFile.Length && maxWireDiameter == 0; i++)
                if (wireDiameterText == FirstLineOfFile[i])
                    maxWireDiameter = Convert.ToDouble(SecondLineOfFile[i]);



        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void button_example_Click(object sender, EventArgs e)
        {
            Reset();
            //setting values

            sectionNum = 5;
            same = true;
            sectionWidth = 5;
            betweenSections = 2.5;
            coilNum = new int[1];
            coilNum[0] = 100;
            wireType = "ПЭЛШО";

            diameter = 8.5;


            //setting the window

            textBox_section_num.Text = "5";
            radioButton_same.Checked = true;
            textBox_diameter.Text = "8,5";
            textBox_section_width.Text = "5";
            textBox_between_sections.Text = "2,5";
            comboBox_wire_type.SelectedIndex = comboBox_wire_type.Items.IndexOf(wireType);
            dataGridView_num.Rows[0].Cells[0].Value = 100;

            if (ReadFromFile("ПЭЛШО.txt", ref FirstLineOfFile, ref SecondLineOfFile, true))
            {
                //fill the combobox
                for (int i = 0; i < FirstLineOfFile.Length; i++)
                    comboBox_wire_diameter.Items.Add(FirstLineOfFile[i]);

                comboBox_wire_diameter.SelectedIndex = 22;
                wireDiameter = 0.25;
                maxWireDiameter = 0.35;
            }

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            String errorText = "Ошибка ввода следующих полей:";
            bool error = ReadAndCheck(ref errorText);
            L = 0;

            if (error)
                MessageBox.Show(errorText);
            else
            {
                Solve();
                label_result.Text = Convert.ToString(Math.Round(L, 3)) + " мкГ";
                PaintInd();
            }


        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void ReadmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("README.txt");

        }

        private void WireTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WireTypes wireTypes = new WireTypes();
            wireTypes.ShowDialog();

            UpdateWireTypes();

            if (comboBox_wire_type.SelectedIndex == -1)
            {
                //reset wire diameter window
                comboBox_wire_diameter.SelectedIndex = -1;
                comboBox_wire_diameter.Items.Clear();

                wireType = "";

                wireDiameter = 0;
                maxWireDiameter = 0;
            }
                
        }
        
        private void MethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cqf.su/technics/technics51-Universal.php");
        }  

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      
        void PaintInd()
        {
            Bitmap myBitmap = new Bitmap("section.tif");
            Graphics g = panelDraw.CreateGraphics();
            g.Clear(panelDraw.BackColor);

            

            //размеры области рисования
            float outerSizeX = panelDraw.Width;
            float outerSizeY = panelDraw.Height;

            //размеры внутреннего прямоугольника, в 2 раза меньшего области рисования
            float innerSizeX = outerSizeX / 2;
            float innerSizeY = outerSizeY / 2;

            float indent = 30;
            float scale = 10;

            //размеры в масштабе 
            float betweenSectionsScaled = Convert.ToSingle(scale * betweenSections);
            float sectionWidthScaled = Convert.ToSingle(scale * sectionWidth);
            float diameterScaled = Convert.ToSingle(scale * diameter);

            //размеры рисунка в текущем масштабе
            float xSize = (sectionNum * (betweenSectionsScaled + sectionWidthScaled) - betweenSectionsScaled + indent * 2);
            float ySize = Convert.ToSingle(scale * MaxSectionDiameter());

            //цикл для масштабирования рисунка
             while ((xSize <= innerSizeX && ySize <= innerSizeY) || xSize > outerSizeX || ySize > outerSizeY ) 
            {
                if (xSize <= innerSizeX && ySize <= innerSizeY)
                    scale *= 1.001F;
            
                else if (xSize > outerSizeX || ySize > outerSizeY)
                    scale /= 1.001F;
                
                betweenSectionsScaled = Convert.ToSingle(scale * betweenSections);
                sectionWidthScaled = Convert.ToSingle(scale * sectionWidth);
                diameterScaled = Convert.ToSingle(scale * diameter);

                xSize = (sectionNum * (betweenSectionsScaled + sectionWidthScaled) - betweenSectionsScaled + indent * 2);
                ySize = Convert.ToSingle(scale * MaxSectionDiameter());
 
            }

            double C = coilNum[0] * Math.Pow((kn * maxWireDiameter), 2) / sectionWidth;
            float D2Scaled = Convert.ToSingle(scale * (diameter + 2 * C));

            //координаты центра области рисования

            float yCenter = panelDraw.Height / 2;
            float xCenter = panelDraw.Width / 2;

            //отрисовка начала каркаса

            
            PointF topLineStart1 = new PointF { X = xCenter - (sectionNum * (betweenSectionsScaled + sectionWidthScaled) - betweenSectionsScaled) / 2 - indent, Y = yCenter - diameterScaled / 2 };
            PointF topLineStart2 = new PointF { X = topLineStart1.X + indent, Y = yCenter - diameterScaled / 2 };

            PointF bottomLineStart1 = new PointF { X = topLineStart1.X, Y = topLineStart1.Y + diameterScaled };
            PointF bottomLineStart2 = new PointF { X = bottomLineStart1.X + indent, Y = topLineStart1.Y + diameterScaled };

            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush, 4);

            g.DrawLines(pen, new PointF[] {topLineStart2, topLineStart1, bottomLineStart1, bottomLineStart2 });


            PointF top1 = new PointF(), top2 = new PointF(), bottom1 = new PointF(), bottom2 = new PointF();
            RectangleF rect = new RectangleF();

            //отрисовка секций

            for (int i = 0; i < sectionNum; i++)
            {
                if (!same)
                {
                    //размеры следующей секции

                    C = coilNum[i] * Math.Pow((kn * maxWireDiameter), 2) / sectionWidth;
                    D2Scaled = Convert.ToSingle(scale * (diameter + 2 * C));
                }

                rect = new RectangleF((topLineStart2.X + i * sectionWidthScaled + i * betweenSectionsScaled), yCenter - D2Scaled/2, sectionWidthScaled, D2Scaled);
                g.DrawImage(myBitmap, rect);


                //продолжение каркаса после каждой секции

                top1 = new PointF { X = rect.X + rect.Width, Y = topLineStart2.Y };
                top2 = new PointF { X = rect.X + rect.Width + betweenSectionsScaled, Y = topLineStart2.Y };
                bottom1 = new PointF { X = rect.X + rect.Width, Y = bottomLineStart2.Y };
                bottom2 = new PointF { X = rect.X + rect.Width + betweenSectionsScaled, Y = bottomLineStart2.Y };

                if (i == sectionNum - 1)
                {
                    //завершение каркаса 

                    top2.X += indent - betweenSectionsScaled;
                    bottom2.X += indent - betweenSectionsScaled;
                    g.DrawLines(pen, new PointF[] { top1, top2, bottom2, bottom1 });
                }
                else
                {
                    g.DrawLine(pen, top1, top2);
                    g.DrawLine(pen, bottom1, bottom2);
                }
            }

  
        }

        void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            if (L != 0)
                PaintInd();
        }

        void panelDraw_Resize(object sender, EventArgs e)
        {
            if (L != 0 && panelDraw.Height !=0 && panelDraw.Width != 0)
                PaintInd();
        }
    

    }
}
