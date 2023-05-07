using System;

namespace NumereComplexe
{
    internal class Complex
    {
        private double re;
        private double im;

        public Complex() : this(0, 0)
        {
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            Complex t = new Complex();
            t.re = a.re + b.re;
            t.im = a.im + b.im;
            return t;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex t = new Complex();
            t.re = a.re - b.re;
            t.im = a.im - b.im;
            return t;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            Complex t = new Complex();
            t.re = a.re * b.re - a.im * b.im;
            t.im = a.im * b.re + a.re * b.im;
            return t;
        }

        public static Complex operator /(Complex a, Complex b)
        {
            Complex c = b.Conjugat();
            Complex up = a * c;
            Complex down = b * c;
            Complex t = new Complex();
            t.re = up.re / down.re;
            t.im = up.im / down.re;
            return t;
        }

        public Complex Conjugat()
        {
            Complex tmp = new Complex();
            tmp.re = re;
            tmp.im = -1 * im;
            return tmp;
        }

        public double Modul()
        {
            return Math.Sqrt(re * re + im * im);
        }

        public string View()
        {
            if (im > 0)
                return re.ToString("0.00") + " " + "+ i" + im.ToString("0.00");
            else
                return re.ToString("0.00") + " " + "- i" + (-1 * im).ToString("0.00");
        }
    }
}