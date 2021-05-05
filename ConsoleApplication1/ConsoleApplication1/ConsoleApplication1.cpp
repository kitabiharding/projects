#include <stdio.h>
#include <cmath>
#include <iostream>

double ff1(double x, double y)
{
	return tan(x * y + 0.3) - pow(x, 2);
}
double ff2(double x, double y)
{
	return 0.8 * pow(x, 2) + 2 * pow(y, 2) - 1;
}
double dff1y(double x, double y)
{
	return (1 + (pow(tan(x * y + 0.3), 2))) * x;
}
double dff1x(double x, double y)
{
	return (1 + (pow(tan(x * y + 0.3), 2))) * y - 2 * x;
}
double dff2x(double x)
{
	return 1.6 * x;
}
double dff2y(double y)
{
	return 4 * y;
}
float i, j, x, y, xo, yo, f1, f2, f10, f20, ay, ax, bx, df1y, df1x, df2y, df2x, dw, dw1, dw2, delX, delY, m;
float E = 0.001;

int main()
{ //начальное приближение найдено заранее графически в программе maple (скриншот прикреплен)
	{
		xo = 0.9;
		yo = 0.42;
		x = xo;
		y = yo;
		f1 = ff1(x, y);
		f2 = ff2(x, y);
		df1y = dff1y(x, y);
		df1x = dff1x(x, y);
		df2y = dff2y(y);
		df2x = dff2x(x);
		dw = df1x * df2y - df1y * df2x;
		dw1 = df1y * f2 - f1 * df2y;
		dw2 = f1 * df2x - df1x * f2;
		delX = dw1 / dw;
		delY = dw2 / dw;
		if (abs(delX) > abs(delY))
		{
			m = delX;
		}
		else
		{
			m = delY;
		}
		while (abs(m) > E)
		{
			f10 = ff1(xo, yo);
			f20 = ff1(xo, yo);
			ay = dff1y(x, y);
			ax = dff1x(x, y);
			bx = dff2x(x);
			dw = df1x * df2y - df1y * df2x;
			dw1 = df1y * f2 - f1 * df2y;
			dw2 = f1 * df2x - df1x * f2;
			delX = dw1 / dw;
			delY = dw2 / dw;
			x = x + delX;
			y = y + delY;
			if (abs(delX) > abs(delY))
			{
				m = delX;
			}
			else
			{
				m = delY;
			}

		}
	}

	printf("Решение: delX=%f, delY=%f", delX, delY);
	return 0;
}
