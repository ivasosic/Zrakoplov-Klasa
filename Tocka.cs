﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZrakoplovKlasa
{
    public class TOCKA
    {
        private double m_x;
        private double m_y;

        public double X
        {
            get { return m_x; }
            set { m_x = value; }

        }

        public double Y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        public TOCKA(double x = 0, double y = 0)
        {
            m_x = x;
            m_y = y;
        }


        public void ispis()
        {
            Console.WriteLine("({0},{1})", m_x, m_y);
        }

        public double udaljenost(TOCKA T)
        {
            double rez = 0;
            rez = ((m_x - T.m_x) * (m_x - T.m_x) + (m_y - T.m_y) * (m_y - T.m_y));

            return Math.Sqrt(rez);
        }


        }
}

