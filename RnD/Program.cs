using DbAccessLayer;
using EntityOperationsLibrary;
using ExceptionEntities;
using StaticEntitiesLibrary;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnD
{
    class Program
    {
        static void Main(string[] args)
        {
            //CodeCompileUnit ccu = new CodeCompileUnit();
            //CodeNamespace ns = new CodeNamespace("Test.Entity");
            //CodeTypeDeclaration type = new CodeTypeDeclaration("Order");
            //type.BaseTypes.Add(new CodeTypeReference("Entity"));
            //ns.Types.Add(type);
            //ccu.Namespaces.Add(ns);
            //Microsoft.VisualBasic.VBCodeProvider cp = new Microsoft.VisualBasic.VBCodeProvider();
            //StreamWriter sw = new StreamWriter(@"C:\4_11_EDP\hede.txt");
            //System.CodeDom.Compiler.CodeGeneratorOptions op = new System.CodeDom.Compiler.CodeGeneratorOptions();
            //cp.GenerateCodeFromCompileUnit(ccu, sw, op);
            //sw.Close();

            //using (DbManager db = new DbManager())
            //{
            //    db.Parameters.Add(new CrParameter() { Name = "Code", Size = 50, Value = "P_Code_V2", Type = CrType.STR });
            //    db.Parameters.Add(new CrParameter() { Name = "Price", Size = 4, Value = 3, Type = CrType.INT });
            //    db.ExecuteNonQuery("insert into [Order](Code,Price) values (~Code, ~Price)");
            //}

            CoreEntityLibrary.Entity e = new CoreEntityLibrary.Entity("Order");
            e.Set("Id", 1);
            e.Set("Code", "dinamik_000_EN");
            e.Set("Price", 1000);


            //string code = e.Get<string>("Code");

            EntityManager.Insert(e);


            Order o = new Order();
            o.Id = 1;
            o.Code = "static_000_EN";
            o.Price = 233;

            EntityManager.Insert(o);



            //try
            //{
            //    throw new CoreLevelException();

            //}
            //catch(Exception e)
            //{
            //    ExceptionManagementLibrary.ExceptionManager.Handle(e);
            //}

            //Hede(GetList());

            //((IList<int>)new int[] { 1, 2, 3 }).Add(22);

            //try
            //{

            //    new Test().ThrowWithoutE();
            //    Console.WriteLine("------------");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{

            //    new Test().ThrowWithE();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);
            //}


        }

        public static void Hede(ICollection<int> coll)
        {
           
                coll.Add(5);

            foreach (var item in coll)
            {
                Console.WriteLine(item);
            }
        }

        public static IList<int> GetList()
        {
            return new int[] { 1, 2, 3, 4 };
           // return new ReadOnlyCollection<int>(new List<int> { 1, 2, 3, 4 });

            //return new List<int>() { 1, 2, 3, 4 };
        }
    }

    public class Test
    {
        public void ThrowWithE()
        {
            try
            {
                new MathOps().Operation(1, 0);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void ThrowWithoutE()
        {
            try
            {
                new MathOps().Operation(1, 0);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }

    public class MathOps
    {
        public double Operation(int a, int b)
        {
            return a / b;
        }
    }
}
