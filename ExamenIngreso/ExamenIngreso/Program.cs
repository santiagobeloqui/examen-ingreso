using System;

namespace ExamenIngreso
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda tienda = new Tienda("La Roperia", "San Martin 123");
            Vendedor vendedor = new Vendedor("Santiago", "Beloqui", 123456);
            
            Camisa camisaCortaMao = new Camisa(true, true, 200);
            tienda.PrendasEnVenta.Add(camisaCortaMao);
            Camisa camisaCortaNoMao = new Camisa(true, false, 300);
            tienda.PrendasEnVenta.Add(camisaCortaNoMao);
            Camisa camisaLargaMao = new Camisa(false, true, 150);
            tienda.PrendasEnVenta.Add(camisaLargaMao);
            Camisa camisaLargaNoMao = new Camisa(false, false, 350);
            tienda.PrendasEnVenta.Add(camisaLargaNoMao); Pantalon pantalonChupin = new Pantalon(true, 1500);
            tienda.PrendasEnVenta.Add(pantalonChupin);
            Pantalon pantalonNormal = new Pantalon(false, 500);
            tienda.PrendasEnVenta.Add(pantalonNormal);

            MenuManager menuManager = new MenuManager(tienda, vendedor);
            menuManager.IniciarMenu();            
        }
    }
}
