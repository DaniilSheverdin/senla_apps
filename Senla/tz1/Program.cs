using System;

namespace tz6
{
	class Program
	{
		static void Main(string[] args)
		{
			int M = 30;
			di[] D = new di[] { new di(16, 20), new di(12, 14) };
			di[] r = new di[0];
			int P = Perebor(M, D, out r);
			foreach (di dt in D)
				Console.WriteLine(dt.ToString());
			Console.WriteLine(P);
			foreach (di dt in r)
				Console.WriteLine(dt.ToString());
			Console.ReadKey();
		}
		static int Perebor(int M, di[] D, out di[] r)
		{
			int P = 0;
			int pt = 0;
			r = new di[0];
			di[] rt = new di[0];
			foreach (di dt in D)
			{
				if (M >= dt.M)
				{
					pt = Perebor(M - dt.M, D, out r);
					if (pt + dt.P > P)
					{
						P = pt + dt.P;
						Array.Resize(ref r, r.Length + 1);
						r[r.Length - 1] = dt;
						rt = r;
					}
				}
			}
			r = rt;
			return P;
		}
	}
	class di
	{
		public di() { }
		public di(int m1, int p1)
		{
			M = m1;
			P = p1;
		}
		int mi, pi;
		public int M
		{
			get { return mi; }
			set
			{
				if (value <= 0)
					Console.WriteLine("нельзя так");
				else mi = value;
			}
		}
		public int P
		{
			get { return pi; }
			set { pi = value; }
		}
		public override
			string ToString()
		{
			string s = "";
			s += "(" + M + ", " + P + ")";
			return s;
		}
	}
}
