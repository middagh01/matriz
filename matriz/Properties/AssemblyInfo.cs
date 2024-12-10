using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// La información general sobre un ensamblado se controla mediante el siguiente 
// conjunto de atributos. Cambie estos atributos para modificar la información
// asociada con un ensamblado.
[assembly: AssemblyTitle("matriz")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("matriz")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Si establece ComVisible como false, los tipos de este ensamblado no estarán visibles 
// para los componentes COM.  Si necesita obtener acceso a un tipo de este ensamblado desde 
// COM, establezca el atributo ComVisible como true en este tipo.
[assembly: ComVisible(false)]

// El siguiente GUID sirve como identificador de typelib si este proyecto se expone a COM
[assembly: Guid("4f56d57f-3cb9-48ea-b2fc-726498acfa62")]

// La información de versión de un ensamblado consta de los cuatro valores siguientes:
//
//      Versión principal
//      Versión secundaria 
//      Número de compilación
//      Revisión
//
// Puede especificar todos los valores o establecer como predeterminados los números de compilación y de revisión 
// mediante el carácter '*', como se muestra a continuación:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

         public void pregunta2e()
         {
             int may = 0;
             int elemay=0;
             for (int c1 = 1; c1 <= c; c1++)
             {
                 may = 0;
                for (int f1 = 1; f1 <= f; f1++)
                 {
                    int ele = x[f1, c1];
                    int fr=frecuenciaCol(c1,ele);
                    if (fr > may)
                    {
                        may = fr;
                        elemay = ele;
                    }
                 }
                x[f + 1, c1] = elemay;
               x[f + 2, c1] = may;
             }
             f = f + 2;
            
         }

        int frecuenciaCol(int c1, int ele)
        {
            int fr = 0;
            for (int f1 = 1; f1 <= f; f1++)
            {
                if (x[f1, c1] == ele)
                {
                    fr++;
                }
            }
            return fr;
        }

public void pregunta01()
{
    int s;
    for (int j = 1; j <= this.c; j++)
    {
        s = 0;
        for (int i = 1; i <= this.f; i++)
        {
            if (!this.pertenece(1, i - 1, j, x[i, j]))
                s++;
        }
        x[f + 1, j] = s;
    }
    f++;
    Ord_las_col_x_el_nro_de_eles_difsme();
}

public bool pertenece(int a, int b, int j, int g)
{
    int s = 0;
    while (a <= b)
    {
        if (x[a, j] == g)
        {
            s++;
        }
        a++;
    }
    return s > 0;
}

public void Ord_las_col_x_el_nro_de_eles_difsme()
{
    for (var p = 1; p <= c - 1; p++)
    {
        for (var d = p + 1; d <= c; d++)
        {
            if (x[f, p] > x[f, d])
                Intercambiar_col(d, p);
        }
    }
}
public void Intercambiar_col(int c1, int c2)
{
    for (var f1 = 1; f1 <= f; f1++)
        Intercambiar(f1, c1, f1, c2);
}

public void Ordenar_col_asc()
{
    for (var c1 = 1; c1 <= c; c1++)

    {
        for (var f1 = 1; f1 <= f; f1++)
        {
            for (var f2 = f1 + 1; f2 <= f; f2++)
            {
                if (x[f1, c] < x[f2, c])
                    Intercambiar(f1, c, f2, c);
            }
        }
    }
}

public void Intercambiar(int f1, int c1, int f2, int c2)
{
    int aux = x[f1, c1];
    x[f1, c1] = x[f2, c2];
    x[f2, c2] = aux;
}
