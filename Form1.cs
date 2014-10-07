using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace trpo_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitLabels();
        }
        void InitLabels()        
        {
            
            ansLabels = new Label[maxSize];
            int x = 12;
            int y = 50;
            int dx = 30;
            for (int i = 0; i < maxSize; i++)
            {
                ansLabels[i] = new Label();
                ansLabels[i].Location = new Point(x, y);
                ansLabels[i].Width = 33;
                ansLabels[i].Font = new Font("Microsoft Sans Serif", 14F);
                ansLabels[i].ForeColor = Color.Black;
                x = x + dx;
            }
            
            this.Controls.AddRange(ansLabels);  
        }
        void clearLabels()
        {
            for (int i = 0; i < maxSize; i++)
            {
                ansLabels[i].ForeColor = Color.Black;
                ansLabels[i].Text = "";
            }
        }
        int maxSize = 23;
        Label[] ansLabels;
        private void btnGo_Click(object sender, EventArgs e)
        {
            clearLabels();
            txbxRes.Text = "";
            char[] sep = new char[] { ' ',',' };
            string[] s =      txbxInpSeq.Text.Split(sep,StringSplitOptions.RemoveEmptyEntries);
            int[] a = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            int start = 0, minLen = 0,start2 = 0,minLen2 =0 ;
            //замер времени
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int maxSum = linerAlgo(a, ref start, ref minLen);
            stopWatch.Stop();            
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:f7}", ts.TotalSeconds);
            stopWatch.Reset();
            stopWatch.Start();
            int automat = linerAlgoAutomat(a, ref start2, ref minLen2);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            string elapsedTime2 = String.Format("{0:f7}",ts.TotalSeconds);
            string answer = "{0} алгоритм: MAXSUMM = {1}, MINLEN = {2}, время работы = {3}";
            txbxRes.Text += "Длина последовательности = " + a.Length+Environment.NewLine;
            txbxRes.Text += string.Format(answer, "С автоматом", automat, minLen2, elapsedTime2) + Environment.NewLine;
            txbxRes.Text += string.Format(answer, "Линейный", maxSum, minLen, elapsedTime);
           
            //выделение цветом
            for (int i = 0; i < a.Length; i++)
            {   
                ansLabels[i].Text = a[i].ToString();
                if (i >= start && i < start + minLen)                
                    ansLabels[i].ForeColor = Color.Red;               
            }
          
        }
        enum State 
        {
            Add,Skip
        }

        State checkNum(int sum)//функция перехода к новому состоянию
        {
            if (sum <= 0)
                return State.Skip;
            return State.Add;
        }

        private int linerAlgoAutomat(int[] a, ref int start, ref int minlen) 
        {
            int i = 0;
            int sum = 0, maxsum = 0, len = 0;
            while (i<a.Length)
            {
                if (checkNum(sum += a[i]) == State.Skip)//пропуск
                {
                    sum = 0;
                    len = 0;
                }
                else
                {
                    len++;//накапливаем длинну
                    if (sum > maxsum)//если надо изменить,
                    {
                        minlen = len;
                        start = i - minlen + 1;//определяем откуда стартовали
                        maxsum = sum;
                    }
                    else
                        if (sum == maxsum && len < minlen)//если сумма такая же, то смотрим может меньше длина
                        {
                            minlen = len;
                            start = i - minlen + 1;
                        }
                }
                i++;
            }
            return maxsum;
        }
        private int linerAlgo(int[] a,ref int start,ref int minlen)
        {
            int i=0;
            int sum = 0, maxsum = 0, len = 0;
            while (i < a.Length)
            {
                sum += a[i];
                if (sum <= 0)//состояние ненакопления
                {
                    sum = 0;
                    len = 0;
                }
                else
                {
                    len++;//накапливаем длинну
                    if (sum > maxsum)//если надо изменить,
                    {
                        minlen = len;
                        start = i - minlen + 1;//определяем откуда стартовали
                        maxsum = sum;
                    }
                    else
                        if (sum == maxsum && len < minlen)//если сумма такая же, то смотрим может меньше длина
                        {
                            minlen = len;
                            start = i - minlen + 1;
                        }
                }
                i++;
            }
            return maxsum;
        }
        /*  private int cubixAlgo(int[] a, ref int start, ref int minlen)
       {
           int sum = 0, maxsum = 0, len = 0;
           for (int i = 0; i < a.Length; i++)
           {
               for (int j = i; j < a.Length; j++)
               {
                   len = 0;
                   sum = 0;
                   for (int k = i; k <= j; k++)
                   {
                       sum += a[k];
                       len++;
                   }
                   if (maxsum < sum)
                   {
                       maxsum = sum;
                       start = i;
                       minlen = len;
                   }
                   else
                       if (sum == maxsum && len < minlen)
                       {
                           minlen = len;
                           start = i;
                       }

               }
           }
           return maxsum;
       }*/
     
    }
}
