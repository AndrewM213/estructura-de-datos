using ListaEnlazadaS;

string ListaEnlazadaS;

Locomotora l = new Locomotora();
l.AgregaFinal(1);
l.AgregaFinal(3);
l.AgregaFinal(34);
l.AgregaFinal(15);
l.EliminarUltimo();
//EliminarUltimo();
//EliminarPrimero();
Console.WriteLine(l.VerVagones());