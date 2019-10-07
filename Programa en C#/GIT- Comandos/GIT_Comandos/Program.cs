using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_Comandos
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable comandos_GIT = new DataTable();
            TextFieldParser text = new TextFieldParser("D:\\TrabajoEspecialDeTIO\\Programa en C#\\GIT-Comandos.csv");
            text.Delimiters = new String[] { "," };
            int variable = 0;
            while (true)
            {
                variable++;
                String[] parts = text.ReadFields();//obtiene cada fila
                if (parts == null)
                {
                    break;
                }
                if (variable == 1)
                {
                    for (int i = 0; i < parts.Length; i++)
                    {
                        comandos_GIT.Columns.Add(parts[i].ToString());
                    }
                }
                else
                {
                    comandos_GIT.Rows.Add(parts);
                }
            }
            foreach (DataColumn column in comandos_GIT.Columns)
            {
                Console.WriteLine(column.ColumnName + ":");
                int i = 0;
                foreach (DataRow row in comandos_GIT.Rows)
                   {
                        Console.WriteLine(i + "-" + row[column.ColumnName]);
                        i++;
                   }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
