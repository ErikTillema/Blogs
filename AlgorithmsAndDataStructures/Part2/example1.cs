public static double FindMinimum(Func<double, double> f, double xLowerBound, double xUpperBound, double precision) {
    double xTest = (xUpperBound + xLowerBound) / 2.0;
    if (Math.Abs(xUpperBound - xLowerBound) <= precision) return xTest;
    bool isIncreasing = GetIsIncreasing(f, xTest);
    if (isIncreasing) {
        return FindMinimum(f, xLowerBound, xTest, precision);
    } else {
        return FindMinimum(f, xTest, xUpperBound, precision);
    }
}