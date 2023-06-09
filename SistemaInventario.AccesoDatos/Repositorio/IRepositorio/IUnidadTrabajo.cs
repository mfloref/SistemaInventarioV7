using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    //Este te permite desaserte de cualquier recurso que se haya obtenido del sistema y liberar objetos que
    //ya no se esten usando y que esten consuminedo recursos insecesariamente
    public interface IUnidadTrabajo : IDisposable 
    {
        IBodegaRepositorio Bodega { get; }

        Task Guardar();
    }
}
