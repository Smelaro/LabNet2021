using Lab.Demo.EF.Logic;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();
            ProductsLogic productsLogic = new ProductsLogic();
            EmployeesLogic employeeLogic = new EmployeesLogic();

            Console.WriteLine("¿Que campo queres usar?");
            Console.WriteLine("1. Empleados");
            Console.WriteLine("2. Productos");
            Console.WriteLine("0. Salir");
            Console.Write("Eleccion: ");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            switch (seleccion)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("---EMPLEADOS---");
                    Console.WriteLine("¿Que accion queres hacer?");
                    Console.WriteLine("1. Agregar");
                    Console.WriteLine("2. Borrar");
                    Console.WriteLine("3. Actualizar");
                    Console.WriteLine("4. Mostrar");
                    Console.WriteLine("0. Atras");
                    Console.Write("Eleccion: ");
                    int seleccEmpleado = Convert.ToInt32(Console.ReadLine());
                    switch (seleccEmpleado)
                    {
                        case 0:
                            goto Start;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("---AGREGAR---");
                            Console.Write("Ingrese el apellido: ");
                            string apellidoEmpleado = Console.ReadLine();
                            Console.Write("Ingrese el nombre: ");
                            string nombreEmpleado = Console.ReadLine();
                            Console.Write("Ingrese el cargo: ");
                            string tituloEmpleado = Console.ReadLine();
                            Console.Write("Ingrese el titulo de cortesia (Mr. / Mrs. / Dr.): ");
                            string tituloCortesiaEmpleado = Console.ReadLine();
                            Console.Write("Ingrese fecha de nacimiento (DD/MM/YYYY): ");
                            DateTime fechanacimientoEmpleado = DateTime.Parse(Console.ReadLine());
                            Console.Write("Ingrese fecha de contratacion (DD/MM/YYYY): ");
                            DateTime fechacontratacionEmpleado = DateTime.Parse(Console.ReadLine());
                            Console.Write("Ingrese direccion: ");
                            string direccionEmpleado = Console.ReadLine();
                            Console.Write("Ingresse ciudad: ");
                            string ciudadEmpleado = Console.ReadLine();
                            Console.Write("Ingrese codigo postal: ");
                            string codigopostalEmpleado = Console.ReadLine();
                            Console.Write("Ingrese pais: ");
                            string paisEmpleado = Console.ReadLine();
                            Console.Write("Ingrese telefono: ");
                            string telefonoEmpleado = Console.ReadLine();
                            Console.Write("Ingrese extension de telefono: ");
                            string extesiontelefonoEmpleado = Console.ReadLine();
                            employeeLogic.Add(new Employees
                            {
                                LastName = apellidoEmpleado,
                                FirstName = nombreEmpleado,
                                Title = tituloEmpleado,
                                TitleOfCourtesy = tituloCortesiaEmpleado,
                                BirthDate = fechanacimientoEmpleado,
                                HireDate = fechacontratacionEmpleado,
                                Address = direccionEmpleado,
                                City = ciudadEmpleado,
                                PostalCode = codigopostalEmpleado,
                                Country = paisEmpleado,
                                HomePhone = telefonoEmpleado,
                                Extension = extesiontelefonoEmpleado
                            });
                            Console.WriteLine("Empleado agregado con exito!");
                            Console.ReadLine();
                            goto Start;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("---BORRAR---");
                            Console.Write("Inserte ID a borrar: ");
                            int idEmpleado = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                employeeLogic.Delete(idEmpleado);
                                Console.WriteLine("Empleado eliminado.");
                                Console.ReadLine();
                                goto Start;
                            }
                            catch (ArgumentNullException)
                            {
                                Console.WriteLine("ID no encontrado.");
                                Console.ReadLine();
                                goto Start;
                            }

                        case 3:
                            Console.Clear();
                            Console.WriteLine("---MODIFICAR---");
                            Console.Write("Inserte ID a modificar: ");
                            idEmpleado = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese el apellido: ");
                            apellidoEmpleado = Console.ReadLine();
                            Console.Write("Ingrese el nombre: ");
                            nombreEmpleado = Console.ReadLine();
                            Console.Write("Ingrese el cargo: ");
                            tituloEmpleado = Console.ReadLine();
                            Console.Write("Ingrese direccion: ");
                            direccionEmpleado = Console.ReadLine();
                            Console.Write("Ingresse ciudad: ");
                            ciudadEmpleado = Console.ReadLine();
                            Console.Write("Ingrese codigo postal: ");
                            codigopostalEmpleado = Console.ReadLine();
                            Console.Write("Ingrese pais: ");
                            paisEmpleado = Console.ReadLine();
                            Console.Write("Ingrese telefono: ");
                            telefonoEmpleado = Console.ReadLine();
                            Console.Write("Ingrese extension de telefono: ");
                            extesiontelefonoEmpleado = Console.ReadLine();
                            try
                            {
                                employeeLogic.Update(new Employees
                                {
                                    EmployeeID = idEmpleado,
                                    LastName = apellidoEmpleado,
                                    FirstName = nombreEmpleado,
                                    Title = tituloEmpleado,
                                    Address = direccionEmpleado,
                                    City = ciudadEmpleado,
                                    PostalCode = codigopostalEmpleado,
                                    Country = paisEmpleado,
                                    HomePhone = telefonoEmpleado,
                                    Extension = extesiontelefonoEmpleado
                                });
                                Console.WriteLine("Empleado modificado.");
                                Console.ReadLine();
                                goto Start;
                            }
                            catch (ArgumentNullException)
                            {
                                Console.WriteLine("No se encuentra el ID del empleado.");
                                Console.ReadLine();
                                goto Start;
                            }
                        case 4:
                            Console.Clear();
                            Console.WriteLine("---MOSTRAR---");
                            foreach (var item in employeeLogic.GetAll())
                            {
                                Console.WriteLine($"ID: {item.EmployeeID}, {item.TitleOfCourtesy}, {item.LastName} {item.FirstName}, Cargo: {item.Title}");
                            }
                            Console.ReadLine();
                            goto Start;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("---PRODUCTOS---");
                    Console.WriteLine("¿Que accion queres hacer?");
                    Console.WriteLine("1. Agregar");
                    Console.WriteLine("2. Borrar");
                    Console.WriteLine("3. Actualizar");
                    Console.WriteLine("4. Mostrar");
                    Console.WriteLine("0. Atras");
                    Console.Write("Eleccion: ");
                    int seleccProductos = Convert.ToInt32(Console.ReadLine());
                    switch (seleccProductos)
                    {
                        case 0:
                            goto Start;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("---AGREGAR---");
                            Console.Write("Ingrese el nombre: ");
                            string nombreProducto = Console.ReadLine();
                            Console.Write("Ingrese el precio: ");
                            int precioProducto = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese el stock: ");
                            var stockProducto = Convert.ToInt16(Console.ReadLine());
                            productsLogic.Add(new Products
                            {
                                ProductName = nombreProducto,
                                UnitPrice = precioProducto,
                                UnitsInStock = stockProducto
                            });
                            Console.WriteLine("Producto agregado con exito!");
                            Console.ReadLine();
                            goto Start;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("---BORRAR---");
                            Console.Write("Inserte ID a borrar: ");
                            int idProducto = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                productsLogic.Delete(idProducto);
                                Console.WriteLine("Producto eliminado.");
                                Console.ReadLine();
                                goto Start;
                            }
                            catch (ArgumentNullException)
                            {
                                Console.WriteLine("ID no encontrado.");
                                Console.ReadLine();
                                goto Start;
                            }

                        case 3:
                            Console.Clear();
                            Console.WriteLine("---MODIFICAR---");
                            Console.Write("Inserte ID a modificar: ");
                            idProducto = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese el nombre: ");
                            nombreProducto = Console.ReadLine();
                            precioProducto = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese el stock: ");
                            stockProducto = Convert.ToInt16(Console.ReadLine());
                            try
                            {
                                productsLogic.Update(new Products
                                {
                                    ProductID = idProducto,
                                    ProductName = nombreProducto,
                                    UnitPrice = precioProducto,
                                    UnitsInStock = stockProducto

                                });
                                Console.WriteLine("Empleado modificado.");
                                Console.ReadLine();
                                goto Start;
                            }
                            catch (ArgumentNullException)
                            {
                                Console.WriteLine("No se encuentra el ID del producto.");
                                Console.ReadLine();
                                goto Start;
                            }
                        case 4:
                            Console.Clear();
                            Console.WriteLine("---MOSTRAR---");
                            foreach (var item in productsLogic.GetAll())
                            {
                                Console.WriteLine($"ID: {item.ProductID}, nombre: {item.ProductName}, stock: {item.UnitsInStock}, precio: {item.UnitPrice}.");
                            }
                            Console.ReadLine();
                            goto Start;
                    }
                    break;
            }
            Console.WriteLine("Adios!");
            Console.ReadLine();
        }
    }
}
