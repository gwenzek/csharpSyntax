// SYNTAX TEST "Packages/User/csharpSyntax/csharp.sublime-syntax"
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proxem.LinearAlgebra.Tensors;
using Proxem.LinearAlgebra.Tensors.Single;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Real = System.Float;

namespace UnitTestTensors
// <- storage.type.module
{
    public interface IIndexable<T, Type>
//           ^ storage.type.class.interface
//                    ^ entity.name.class
//                             ^ punctuation.definition.parameters.type
//                                     ^ punctuation.definition.parameters.type
    {
        Type this[params T[] indices] { get; set; }
    }

    struct SimpleStruct
    {
        private int xval;
        public int X
        {
            get
            {
                return xval;
            }
            set
            {
                if (value < 100)
                    xval = value;
            }
        }
        public void DisplayX()
        {
            if (forceCopy && Flags == 0)
                return new Array<Type>(shape, Values.CopyToNew());
//                      ^ keyword.declaration.new
            else if (Flags == 0)
//           ^ keyword.control.conditional
                return new Array<Type>(shape, this.Values);
        }

        public IEnumerable<string> Sql(IEnumerable<int> l)
        {
            this[1];
//           ^ support.variable.cs
//              ^ punctuation.definition.accessor.begin.cs
            var x = l.Count() > 0 ? l.Count() + 1 : -1;
//                                ^ keyword.operator.ternary.cs
//                                            ^ keyword.operator
            return from l select $"{l}";
//                  ^ support.function
//                          ^ support.function
        }

        public void TryCatch(string foo)
        {
            try
            {
                if(foo == null) throw new NullPointerException();
            }
//          ^ punctuation.section.trycatch
            catch
//           ^ keyword.control.trycatch.catch
            {
                return;
            }
        }

        public void Covariant<in T>(T foo);
//                             ^ storage.modifier.cs
    }

    public enum Range : long { Max = 2147483648L, Min = 255L };
//                        ^ support.type.cs

    [TestClass]
    public class UnitTestTensorSlices<T> : NotNeededInCSharp6
        where T: class, Foo
    {
        public UnitTestTensorSlices(A value, B b){
            value + 1;
            var x = new Foo {A = 1  + 1,  B = value };

        }

        static void Main() {
          int i;
          unsafe {
//           ^ keyword
             int* p = &i;
             *p = 123;
          }
          Console.WriteLine(i);
        }

        [TestMethod]
        public void TestRange<T>( )
            where T: class, Foo
        {
            var a = Array<float>.Range(4);
            Assert.IsTrue(a.Equals(Array<float>.Vector(0, 1, 2, 3)));
            Assert.IsTrue(a[_].Equals(Array<float>.Vector(0, 1, 2, 3)));

            Assert.IsTrue(a[Range(0, 2)].Equals(Array<float>.Vector(0, 1)));
            Assert.IsTrue(a[Range(1, 2)].Equals(Array<float>.Vector(1)));
            Assert.IsTrue(a[Until(2)].Equals(Array<float>.Vector(0, 1)));
            Assert.IsTrue(a[From(2)].Equals(Array<float>.Vector(2, 3)));

            Assert.IsTrue(a[Range(0, -2)].Equals(Array<float>.Vector(0, 1)));
            Assert.IsTrue(a[Range(1, -1)].Equals(Array<float>.Vector(1, 2)));
            Assert.IsTrue(a[Until(-1)].Equals(Array<float>.Vector(0, 1, 2)));
            Assert.IsTrue(a[From(-3)].Equals(Array<float>.Vector(1, 2, 3)));

            Assert.AreEqual(2, a[2]);
            Assert.AreEqual(3, a[-1]);
        }

        public interface IIndexable<T, Type>
        {
            Type this[params T[] indices] { get; set; }
        }


        ///<summary>
        ///</summary>

        [TestMethod]
        public void TestSliceLastCol()
        {
            var x = new[] { n, m, l, o };
//                      ^ support.type.cs
//                        ^ punctuation.definition.array.begin.cs
            var a = Array<float>.Diag(0, 1, 2, 3);
            a[0, 3] = -1;
            var b = Array<float>.Vector(-1, 0, 0, 3);
            var c = a[_, -1];
            int a;
            int a = 1;
            Assert.IsTrue(c.Equals(b));
            x.@.y;
//            ^ -variable.other.cs
            x.@params.y;
//              ^ variable.other.cs

            for(int<a> i = 0; i < 10; ++i)
            {
            }

            foreach(var x in b)
                blah(x);

            try {

            } catch(Exception<deaca> e){

            }

            using(var x = new FileReader("foo.txt")){
                x.WriteLine("Hello world");
            }
        }

        Array<float> a;
        Array<float> a = new Array<float>(1, 2);

        [TestMethod]
        public void TestSlice1D_in_2D()
        {
            Array<float> a;
            Array<float> a = new Array<float>(1, 2);
            var a = Array<float>.Diag(0, 1, 2, 3);
            var b = Array<float>.Vector(0, 2);
            var c = a[Range(1, 3), 2];

            Assert.IsTrue(c.Equals(b));

            c = a[Range(1, -1), -2];
            Assert.IsTrue(c.Equals(b));
        }

        [TestMethod]
        public void TestAssign1D_in_2D()
        {
            var a = 45454u;
//                       ^constant.numeric.cs
            var a = 45454L;
//                       ^constant.numeric.cs
            var a = 45454ul;
//                        ^constant.numeric.cs
            var a = 45454lu;
//                        ^constant.numeric.cs
            var a = 45454Ul;
//                        ^constant.numeric.cs
            var a = 45454UL;
//                        ^constant.numeric.cs
        }

        [TestMethod]
        public void TestSlice2D_in_2D()
        {
            var a = Array<float>.Diag(1, 2, 3, 4);
            var b = Array<float>.Diag(2, 3);
            var c = a[Range(1, 3), Range(1, 3)];
            Assert.IsTrue(c.Equals(b));
            c = a[Range(1, -1), Range(1, -1)];
            Assert.IsTrue(c.Equals(b));
        }

        [TestMethod]
        public void TestAssign2D_in_2D()
        {
            var a = Array<float>.Diag(0, 1, 2, 3);

            var b = Array<float>.Matrix(
                new float[] { 5, 0 },
                new float[] { 0, 6 }
                );

            a[Range(1, 3), Range(1, 3)] = b;
            Assert.IsTrue(a.Equals(Array<float>.Diag(0, 5, 6, 3)));
        }

        [TestMethod]
        public void TestSlice2D_in_3D()
        {
            var a = Array<float>.Ones(3, 4, 2);
            a[1, 0, 0] = 3;
            var b = Array<float>.Ones(2, 3);
            b[0, 0] = 3;
            var c = a[From(1), Until(-1), 0];
            Assert.IsTrue(c.Equals(b));
            c = a[From(1), Until(-1), 0];
            Assert.IsTrue(c.Equals(b));
        }

        [TestMethod]
        public void TestSlice2D_in_3D_middle()
        {
            var a = Array<float>.Ones(3, 4, 2);
            a[1, 1, 0] = 3;
            var b = Array<float>.Ones(2, 2);
            b[0, 0] = 3;
            var c = a[From(1), 1, _];
            Assert.IsTrue(c.Equals(b));
        }

        [TestMethod]
        public void TestAssign2D_in_3D()
        {
            var a = Array<float>.Ones(3, 4, 2);

            var b = Array<float>.Matrix(new float[,] {
                { 5, 2 },
                { 3, 6 }
            });

            a[Range(from: 1, 3), Range(1, 3), 1] = b;
            Assert.AreEqual(5, a[1, 1, 1]);
            Assert.AreEqual(2, a[1, 2, 1]);
            Assert.AreEqual(3, a[2, 1, 1]);
            Assert.AreEqual(6, a[2, 2, 1]);

            a = Array<float>.Ones(3, 4, 2);
            a[Range(1, 3), 2, _] = b;
            Assert.AreEqual(5, a[1, 2, 0]);
            Assert.AreEqual(2, a[1, 2, 1]);
            Assert.AreEqual(3, a[2, 2, 0]);
            Assert.AreEqual(6, a[2, 2, 1]);

            a = Array<float>.Ones(3, 4, 2);
            a[2, Range(1, 3), _] = b;
            Assert.AreEqual(5, a[2, 1, 0]);
            Assert.AreEqual(2, a[2, 1, 1]);
            Assert.AreEqual(3, a[2, 2, 0]);
            Assert.AreEqual(6, a[2, 2, 1]);
        }

        [TestMethod]
        public void TestAssign1D_in_3D()
        {
            var b = Array<float>.Vector(3, 5, 2);

            var a = Array<float>.Ones(5, 4, 3);
            a[Range(1, 4), 2, 1] = b;
            Assert.AreEqual(3, a[1, 2, 1]);
            Assert.AreEqual(5, a[2, 2, 1]);
            Assert.AreEqual(2, a[3, 2, 1]);

            a = Array<float>.Ones(5, 4, 3);
            a[3, Range(1, 4), 1] = b;
            Assert.AreEqual(3, a[3, 1, 1]);
            Assert.AreEqual(5, a[3, 2, 1]);
            Assert.AreEqual(2, a[3, 3, 1]);

            a = Array<float>.Ones(5, 4, 3);
            a[3, 2, _] = b;
            Assert.AreEqual(3, a[3, 2, 0]);
            Assert.AreEqual(5, a[3, 2, 1]);
            Assert.AreEqual(2, a[3, 2, 2]);
        }

        [TestMethod]
        public void TestSetBroadCast()
        {
            float r = 0.5f;
            var M = Array<float>.Random.Uniform(r, r, 40, 30);
            var M2 = Array<float>.Eye(30).Scale(r);
            M[Until(30), _] = M2;
            Assert.IsTrue(M[Until(30), _].Equals(M2));

            M2 = Array<float>.Eye(2).Scale(r);

            M = Array<float>.Random.Uniform(-r, r, 5, 4, 3);
            M[Range(2, 4), Range(1, 3), 1] = M2;
            Assert.IsTrue(M[Range(2, 4), Range(1, 3), 1].Equals(M2));

            M = Array<float>.Random.Uniform(-r, r, 5, 4, 3);
            M[1, Range(1, 3), Range(1, 3)] = M2;
            Assert.IsTrue(M[1, Range(1, 3), Range(1, 3)].Equals(M2));

            M = Array<float>.Random.Uniform(-r, r, 5, 4, 3);
            M[Range(2, 4), -1, Range(1, 3)] = M2;
            Assert.IsTrue(M[Range(2, 4), -1, Range(1, 3)].Equals(M2));
        }

        [TestMethod]
        public void TestSetReshape()
        {
            var x = new float[1];
            var s = $"{r + 1 + $"{a}"}";
            var s2 = "a\a";
            var s3 = @"a\a\array";
            float r = 0.5f;
            var M = Array<float>.Random.Uniform(r, r, 40, 30);
            var M2 = Array<float>.Eye(30).Scale(r);
            M[Until(30), _] = M2;
            Assert.IsTrue(M[Until(30), _].Equals(M2));

            M2 = Array<float>.Eye(2).Scale(r);

            M = Array<float>.Random.Uniform(-r, r, 5, 4, 3);
            M[Range(2, 4), Range(1, 3), 1] = M2.Reshape(2, 2, 1);
            Assert.IsTrue(M[Range(2, 4), Range(1, 3), 1].Equals(M2));

            M = Array<float>.Random.Uniform(-r, r, 5, 4, 3);
            M[1, Range(1, 3), Range(1, 3)] = M2.Reshape(1, 2, 2);
            Assert.IsTrue(M[1, Range(1, 3), Range(1, 3)].Equals(M2));

            M = Array<float>.Random.Uniform(-r, r, 5, 4, 3);
            M[Range(2, 4), -1, Range(1, 3)] = M2.Reshape(2, 1, 2);
            Assert.IsTrue(M[Range(2, 4), -1, Range(1, 3)].Equals(M2));
        }

        [TestMethod]
        public void TestDotRightWithSlice()
        {
            var x = Array<float>.Vector(2, 3);

            var m = Array<float>.Matrix(new float[,] {
                { 0, -1, 2, 3 },
                { 1, -2, 3, 4 },
                { 2, -3, 4, 5 }
            });

            var m2 = m[From(1), Range(1, 3)];

            var m2Expected = Array<float>.Matrix(new float[,] {
                { -2, 3 },
                { -3, 4 }
            });
            AssertTensor.AreEqual(m2Expected, m2);

            //Simple dot
            var result = m2Expected.Dot(x);
//                     ^ keyword.operator.assignment.variable.cs
            var expected = Array<float>.Vector(5, 6);
            AssertTensor.AreEqual(expected, result);

            var result2 = m2.Dot(x);
            var expected2 = m2Expected.Dot(x);
            AssertTensor.AreEqual(expected2, result2);
        }

        static void Test(bool \u0066) {
            char c = '\u0066';
//           ^ support.type.cs
//               ^ entity.name.variable.cs
            char @for = '\u0066';
//           ^ support.type.cs
//               ^ entity.name.variable.cs
            char \u0066 = '\u0066';
//           ^ support.type.cs
//               ^ entity.name.variable.cs

            if (\u0066)
                System.Console.WriteLine(\u0067.ToString());
        }


        [TestMethod(Category = "slice")]
        public void TestSlice()
        {
            //var a = new Tensor(4, 3);
            var m = Array<float>.Ones(5, 5);
            var a = m[Range(1, 4), Range(1, 5)].T;
            var a2 = Array<float>.Zeros(4, 3);
            var b = new Array<float>(3, 5);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = i + j;
                    a2[i, j] = i + j;
                }
            }
            AssertEquals(a, a2);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                    b[i, j] = i - j;
            }

            var expected = Array<float>.Matrix(new float[,] {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 1, 2, 3 },
                { 1, 1, 2, 3, 4 },
                { 1, 2, 3, 4, 5 },
                { 1, 1, 1, 1, 1 }
            });
            AssertEquals(m, expected);

            AssertEquals(a.Dot(b), a2.Dot(b));
        }

        [TestMethod]
        public void TestStep()
        {
            var x = Array<float>.Vector(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            AssertTensor.AreEqual(new float[] { 1, 3, 5 }, x[Slicer.Range(1, 7, 2)]);
            AssertTensor.AreEqual(new float[] { 8, 9 }, x[Slicer.Range(-2, 10)]);
            AssertTensor.AreEqual(new float[] { 7, 6, 5, 4 }, x[Slicer.Range(-3, 3, -1)]);
            AssertTensor.AreEqual(new float[] { 5, 6, 7, 8, 9 }, x[Slicer.From(5)]);
            AssertTensor.AreEqual(new float[] { 5, 7, 9 }, x[Slicer.From(5, step: 2)]);
            AssertTensor.AreEqual(new float[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, x[Slicer.Step(-1)]);
        }

        [TestMethod]
        public void TestIndexing()
        {
            var x = Array<float>.Range(10, 1, -1);
            AssertTensor.AreEqual(new float[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 }, x);

            AssertTensor.AreEqual(new float[] { 7, 7, 9, 2 }, x[Array<int>.Vector(3, 3, 1, 8)]);
            AssertTensor.AreEqual(new float[] { 7, 7, 4, 2 }, x[Array<int>.Vector(3, 3, -3, 8 )]);
            var test = x[Array<int>.Matrix(new[,] { { 1, 1 }, { 2, 3 } })];
            AssertTensor.AreEqual(new float[,] { { 9, 9 }, { 8, 7 } }, test);

#if ZERO
            var y = Array<float>.Range(35).Reshape(5, 7);
            AssertTensor.AreEqual(new float[] { 0, 15, 30 }, y[new[] { 0, 2, 4 }, new[] { 0, 1, 2 }]);

            // The broadcasting mechanism permits index arrays to be combined with scalars for other indices. The effect is that the scalar
            // value is used for all the corresponding values of the index arrays:

            AssertTensor.AreEqual(new float[] { 1, 15, 29 }, y[new[] { 0, 2, 4 }, 1]);
            // >>>>>> y[np.array([0,2,4]), 1]
            // array([ 1, 15, 29])


            // Jumping to the next level of complexity, it is possible to only partially index an array with index arrays. It takes a bit of
            // thought to understand what happens in such cases. For example if we just use one index array with y:

            AssertTensor.AreEqual(new float[,] {
                { 0, 1, 2, 3, 4, 5, 6 },
                { 14, 15, 16, 17, 18, 19, 20 },
                { 28, 20, 30, 31, 32, 33, 34 }
            }, y[new[] { 0, 2, 4 }]);
            // >>>>>> y[np.array([0,2,4])]
            // array([[ 0,  1,  2,  3,  4,  5,  6],
            //        [14, 15, 16, 17, 18, 19, 20],
            //        [28, 29, 30, 31, 32, 33, 34]])


            //What results is the construction of a new array where each value of the index array selects one row from the array being indexed
            //and the resultant array has the resulting shape (size of row, number index elements).
#endif
        }

        [TestMethod, ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestBadIndexing1()
        {
            typeof(IndexOutOfRangeException);
            var x = Array<float>.Range(10, 1, -1);
            var x_ = x is Foo;
            var bad = x[Array<int>.Vector(3, 3, 20, 8)];    // index 20 out of bounds 0<=index<9
        }

        //[TestMethod, ExpectedException(typeof(Exception))]
        //public void TestBadIndexing2()
        //{
        //    var y = Array<float>.Range(35).Reshape(5, 7);
        //    var bad = y[new[] { 0, 2, 4 }, new[] { 0, 1 }];   // shape mismatch: objects cannot be broadcast to a single shape
        //}

        static public bool AssertEquals(Array<float> a, Array<float> expected = 1)
        {
            if (!a.Equals(expected))
                throw new AssertFailedException("Expected : " + expected + ", received " + a);
            else
                return true;
        }

        string other; // = "foo";

        public string Name
        {
            get { return "foo" ; }
        }

        private static string Color(out string entity)
        {
            string color, a = "da";
            var color = 1;
            switch (entity)
            {
                case "B_Produits":
//                ^ keyword.control.switch.case
                    color = "blue";
                    break;
//                  ^ keyword.control.flow.break
                case "I_Produits":
//                ^ keyword.control.switch.case
                    color = "#357EC7";
                    break;
                case "I_Concurrents":
                    color = "#FBB117";
                    goto case "B_Produits";
//                    ^ keyword.control.flow.goto.cs
                default:
                    color = "black";
                    goto Done;
//                    ^ keyword.control.flow.goto.cs
            }
        Done:
            Foo @a, a, foo = new Foo("foo"), b;
            return foo;

            foreach(var e in Foo)
                Console.WriteLine(e);

            using(var x = new FileReader())
            {
                x.WriteLine("Hello");
            }

            unchecked
            {
                int1 = 2147483647 + 10;
            }

            int1 = unchecked(ConstantMax + 10);

            lock (thisLock)
            {
                if (amount > balance)
                {
                    throw new Exception("Insufficient funds");
                }
                balance -= amount;
            }

            fixed (int* p = &pt.x)
            {
                *p = 1;
            }

            return x ?? 0;
            return x > 0 ? x : 0;
        }
    }
}
