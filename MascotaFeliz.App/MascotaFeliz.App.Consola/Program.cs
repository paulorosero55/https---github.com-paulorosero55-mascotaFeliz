using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;
namespace MascotaFeliz.App.Consola
{
   class Program
    {
  

        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDueno();   
           // Console.WriteLine("----Bunsqueda de dueño por ID----");
           // BuscarDueno(1);
            //ListarDuenosFiltro();
           // Console.WriteLine("\n---Lista de todos los dueños---");
           // ListarDuenos();

           // AddVeterinario(); 
           //Console.WriteLine("\n---Bunsqueda de veterinario por ID---");
            //BuscarVeterinario(1);
            //ListarVeterinariosFiltro();
           // Console.WriteLine("\n---Lista de todos los veterinarios---");
           // ListarVeterinarios();

            AsignarDueno();

            //AddMascota();
            Console.WriteLine("\nBunsqueda de mascota por ID");
            BuscarMascota(1);

            //ListarMascotasFiltro();
            Console.WriteLine("\nLista de todas las mascotas");
            ListarMascotas();


        }
    private static void AddDueno() // crear dueño
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Jacinto",
                Apellidos = "Perez",
                Direccion = "Amazonas",
                Telefono = "3123456534",
                Correo = "jaciperez@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

    private static void BuscarDueno(int idDueno) //consultar dueño
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres+" "+dueno.Apellidos+" "+dueno.Direccion+" "+dueno.Telefono+" "+dueno.Correo);
        }
               
    private static void ListarDuenos() //consultar lista de dueños 
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {

            Console.WriteLine(d.Nombres+" "+d.Apellidos+" "+d.Direccion+" "+d.Telefono+" "+d.Correo);
            }

        }


    private static void AddVeterinario() // crear veterinario
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Elba",
                Apellidos = "Lasso",
                Direccion = "Mijitayo",
                Telefono = "122324325",
                TarjetaProfesional = "TP122343242"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
     
     
     private static void BuscarVeterinario(int idVeterinario) //consultar dueño
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres+" "+veterinario.Apellidos+" "+veterinario.Direccion+" "+veterinario.Telefono+" "+veterinario.TarjetaProfesional);
        }
        

    private static void ListarVeterinarios() //consultar lista de veterinarios
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario v in veterinarios)
            {

            Console.WriteLine(v.Nombres+" "+v.Apellidos+" "+v.Direccion+" "+v.Telefono+" "+v.TarjetaProfesional);
            }

        }
    private static void AddMascota()
        {
            var mascota = new Mascota
            {
                
                Nombre = "PePe",
                Color = "Verde",
                Especie = "Tortuga",
                Raza = "No se",

                
            };
            _repoMascota.AddMascota(mascota);
        }

    private static void BuscarMascota(int idMascota) //consultar mascota
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            
            Console.WriteLine(mascota.Nombre+" "+mascota.Color+" "+mascota.Especie+" "+mascota.Raza);
            Console.WriteLine(mascota.Dueno.Id);
            
        }
    
   private static void ListarMascotas() //listar mascotas
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {

            Console.WriteLine(m.Nombre+" "+m.Color+" "+m.Especie+" "+m.Raza);
            }

        }
        private static void AsignarDueno() //asignar Dueno
        {
            var dueno = _repoMascota.AsignarDueno(3,5);

            Console.WriteLine(dueno.Nombres + " " +dueno.Apellidos+"  ");

        }
    
    } 
    
}