using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Overload_operators
{
    partial class Fraction
    {
        // static type operator (method) +, -
        // перевантаження + неявно забезпечує перевантаження +=, -  -=

        // слід перевантажувати парами == i !=, > i <, >= i <=, true i false
        // перетворення типів explicit(явне), implicit(неявне)

        // [] - через властивість

        public static Fraction operator +(Fraction left, Fraction right) {
            /*int num = left.Num * right.Denom + right.Num * left.Denom;
            int denom = left.Denom * right.Denom;
            Fraction result = new Fraction(num, denom);
            return result;*/

            /*int num = left.Num * right.Denom + right.Num * left.Denom;
            int denom = left.Denom * right.Denom;
            return new Fraction(num, denom);*/

            return new Fraction(left.Num * right.Denom + right.Num * left.Denom, left.Denom * right.Denom);
        }
        public static bool operator ==(Fraction left, Fraction right) {  
            if(ReferenceEquals(left, right)) return true;
            if(left is null || right is null) return false;
            return left.Equals(right); 
        }
        public static bool operator !=(Fraction left, Fraction right)
        {
            return !(left == right);
        }

        public static Fraction operator ++(Fraction left) // two forms ++prefix, postfix
        {
            Fraction fraction = new Fraction(1,1);
            return left + fraction;
        }
        public static bool operator true(Fraction left) {
            return left.Num != 0;
        }
        public static bool operator false(Fraction left)
        {
            return left.Num == 0;
        }
        // перетворення типів можна визначати у дві сторони Fraction -> other type, other type -> Fraction
        public static explicit operator int(Fraction left)
        {
            return left.Num / left.Denom;
        }
        public static implicit operator double(Fraction left)
        {
            return (double)left.Num / left.Denom;
        }
        public static implicit operator Point(Fraction left)
        {
            return new Point(left.Num, left.Denom);
        }
    }
}
