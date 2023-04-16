namespace Task5;

public class Polynomial
{
    private Polynomial[] arrayOfPolynomials;
    private int coefficient;
    private string resultMember;

    public Polynomial(int coefficient)
    {
        this.coefficient = coefficient;
    }

    public Polynomial(params int[] array)
    {
        arrayOfPolynomials = new Polynomial[array.Length];

        for (int i = 0; i < arrayOfPolynomials.Length; i++)
        {
            arrayOfPolynomials[i] = new Polynomial(array[i]);
            arrayOfPolynomials[i].resultMember = arrayOfPolynomials[i] * i;
        }
    }

    public override string ToString()
    {
        string result = "";

        for (int i = 0; i < arrayOfPolynomials.Length; i += 2)
        {
            if (i == arrayOfPolynomials.Length - 1)
            {
                result += arrayOfPolynomials[i].resultMember;
                break;
            }

            if (arrayOfPolynomials[i + 1].resultMember.StartsWith("-"))
            {
                result += arrayOfPolynomials[i] - arrayOfPolynomials[i + 1];
            }
            else
            {
                result += arrayOfPolynomials[i] + arrayOfPolynomials[i + 1];
            }
        }

        return result;
    }


    public static string operator +(Polynomial first, Polynomial second)
    {
        return first.resultMember + "+" + second.resultMember;
    }

    public static string operator -(Polynomial first, Polynomial second)
    {
        return first.resultMember + second.resultMember;
    }

    public static string operator *(Polynomial first, int i)
    {
        switch (i)
        {
            case 0:
                return Convert.ToString(first.coefficient);
            case 1:
                return first.coefficient + "x";
            default:
                return first.coefficient + "x" + "^" + i;
        }
    }
}