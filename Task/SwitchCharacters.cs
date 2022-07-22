// See https://aka.ms/new-console-template for more information

using System.Text;
using Stenn.Task;

dynamic X = "X0";
dynamic Y = "Y0";
dynamic Z = "Z0";

X = new StringBuilder(X);

Y = new StringBuilder(Y);

Z = new StringBuilder(Z);

Y.Append(Z[0]);
Y.Append(Y[1]);

X.Append(Y[0]);
X.Append(X[1]);

Z.Append(X[0]);
Z.Append(Z[1]);

Y.Remove(0, 2);

X.Remove(0, 2);

Z.Remove(0, 2);

Z = Z.ToString();
Y = Y.ToString();
X = X.ToString();

Console.WriteLine(@$"X value: {X}
Y value: {Y}
Z value: {Z}");
