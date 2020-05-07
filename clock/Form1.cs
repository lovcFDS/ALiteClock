using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using 壁纸;
using System.Threading;

namespace clock
{
    public partial class Form1 : Form
    {
        String ymd;
        string city,cityBuffer;
        string filename = "city.txt";
        bool b = true;                  //用来保存位置锁定与否的变量
        public Form1()
        {
            InitializeComponent();
            ReadFile();
            getWeather(city);
            
        }

        //初始化时获取用户上次保存的城市名

        private void ReadFile()
        {
            FileStream file = new FileStream(filename,FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(file,Encoding.Default);
            StreamWriter sw = new StreamWriter(file,Encoding.UTF8);
            if (sr.ReadLine() == null)
            {
                city = "济南";
                sw.Write(city);
                sw.Close();
            }
            else
            {
                file.Close();
                city = File.ReadAllText(filename);
            }
            
        }
        //随机数生成颜色
        private void RandomColor()
        {
            int a, b, g;
            Random r = new Random();
            a = r.Next(0, 256);
            b = r.Next(0, 256);
            g = r.Next(0, 256);
            label1.ForeColor = Color.FromArgb(a, b, g);
            label2.ForeColor = Color.FromArgb(a, b, g);
            label3.ForeColor = Color.FromArgb(a, b, g);
            label4.ForeColor = Color.FromArgb(a, b, g);
        }

        //更改城市文件内的存储
        private void WriteFile(string cityName)
        {
            FileStream file = new FileStream(filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(file,Encoding.UTF8);
            if (cityName != null)
            {
                sw.Write(cityName);
                sw.Close();
            }
            file.Close();
        }

        //时间刷新函数
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "";
            label1.Text = DateTime.Now.ToLongTimeString();
            String week = DateTime.Today.DayOfWeek.ToString();
            if (week == "Monday")
            {
                label3.Text = "周一";
            }else if (week == "Tuesday")
            {
                label3.Text = "周二";
            }else if (week == "Wednesday")
            {
                label3.Text = "周三";
            }else if(week=="Thursday")
            {
                label3.Text = "周四";
            }else if (week == "Friday")
            {
                label3.Text = "周五";
            }else if(week=="Saturday")
            {
                label3.Text = "周六";
            }
            else
            {
                label3.Text = "周日";
            }
            label3.Text += "  ";
            ymd = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Month.ToString() + "月" + DateTime.Now.Day.ToString() + "日";
            label3.Text += ymd;
            if (b1)
            {
                RandomColor();
            }
        }
        int startx=0, starty=0;//保存当前鼠标位置

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left)&& b)
            {
                this.Left += e.X - startx;
                this.Top += e.Y - starty;
            }
        }

      
        //鼠标移动和鼠标右击菜单事件
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startx = e.X;
                startx = e.Y;
            }
            
            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(MousePosition.X, MousePosition.Y);
                contextMenuStrip1.Show(p);
            }
        }
        //web引用 
        cn.com.webxml.www.WeatherWebService w = new cn.com.webxml.www.WeatherWebService();
        //刷新天气
        private void 刷新天气ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getWeather(city);

        }
        //更改城市的天气
        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                cityBuffer = city;
                city = toolStripTextBox1.Text;
                Thread t = new Thread(getWeatherThread);
                t.Start();
                WriteFile(city);
            }
        }
        //开辟新线程  
        private void getWeatherThread()
        {
            getWeather(city);
        }
        //清空按钮之后的文本框
        private void 输入城市ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
        }
        //关闭主程序
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 锁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!b)
            {
                b = true;
                锁定ToolStripMenuItem.Text = "锁定";
            }
            else
            {
                b = false;
                锁定ToolStripMenuItem.Text = "解除锁定";
            }
        }
        //炫彩控制
        bool b1 = false;
        private void 开启炫彩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!b1)
            {
                b1 = true;
                开启炫彩ToolStripMenuItem.Text = "关闭炫彩";
            }
            else
            {
                b1 = false;
                开启炫彩ToolStripMenuItem.Text = "开启炫彩";
            }
        }

        private void 刷新频率ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox2.Text = "";
        }

        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))             //只能输入数字
            {
                e.Handled = true;
            }
        }
        //修改时间刷新频率
        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Interval = Convert.ToInt32(toolStripTextBox2.Text);
            }
        }

        private void 设置颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
        }

        int[] colorArgbs=new int[3];
        private void toolStripTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] colors = toolStripTextBox3.Text.Split('.');
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        colorArgbs[i] = Convert.ToInt32(colors[i]);
                    }

                    Color color = new Color();
                    color = Color.FromArgb(colorArgbs[0], colorArgbs[1], colorArgbs[2]);
                    setForeColor(color);
                }
                catch
                {
                    MessageBox.Show("请按照格式输入：\n255.255.255");
                }
            }
        }
        //更改颜色
        private void setForeColor(Color color)
        {
            label1.ForeColor = color;
            label2.ForeColor = color;
            label3.ForeColor = color;
            label4.ForeColor = color;
        }

        private void toolStripTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != 46)              //如果不是输入数字就不让输入
            {
                e.Handled = true;
            }
        }
        
        private void bing每日壁纸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(getWallPaper);
            t.Start();
        }

        void getWallPaper()
        {
            bingWallpaper bw = new bingWallpaper();
            bw.setWallpaper();
        }
        //调用web获取天气情况
        void getWeather(string city)
        {
            label2.Text = "\n";
            try
            {
                String[] weather = w.getWeatherbyCityName(city);
                if (weather[0].CompareTo("查询结果为空！") == 0)
                {
                    label2.Text = weather[0];
                    city = cityBuffer;
                }
                else
                {
                    //将天气情况写入文件
                    string path = "weather.txt";
                    FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fileStream);
                    for (int j = 0; j < weather.Length; j++)
                    {
                        if (j == 2 || j == 3 || j == 4 || j == 8 || j == 9 || j == 15 || j == 16 || j == 20 || j == 21) ;
                        else
                        {
                            sw.WriteLine(weather[j]);
                        }
                    }
                    sw.Close();
                    //并对返回的字符串组进行修改删除
                    String str = ((weather[10].Replace("；", "\n")).Replace("。", "\n")).Remove(0, 7);
                    label4.Text = weather[0] + "\n" + weather[1];
                    for (int i = 0; i < 10; i++)
                    {

                        if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 8 || i == 9) ;
                        else if (i == 5)
                        {
                            label2.Text += weather[i] + "\t";
                        }
                        else if (i == 6)
                        {
                            label2.Text += weather[6].Remove(0, 5) + "\r\n";
                        }
                        else
                        {
                            label2.Text += weather[i] + "\r\n";
                        }
                    }
                    label2.Text += str;
                }
            }
            catch
            {
                MessageBox.Show("请联网后重试！");
            }
        }
        
    }
}
