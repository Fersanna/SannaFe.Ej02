namespace SannaFe.Ej02
{
    public class AutoFormModel

    {
        public string PrecioIngresado { get; set; }

        public string ModeloIngresado { get; set; }

        public string AñoIngresado { get; set; }

        public string MarcaIngresada { get; set; }

        public string Usuario { get; } = "Fernando Sanna";

        public string Fecha { get; } = DateTime.Now.ToString();



        public String[] Marcas { get; } = new String[] { "Ford", "Fiat", "Chevrolet", "Audi" };

       



        internal string Validar()
        {
            if (!decimal.TryParse(PrecioIngresado, out decimal precio))
            {
                return "El precio ingresado debe ser un numero decimal";

            }

            if (precio <= 0)

            {
                return "El precio ingresado debe ser mayor a 0";
            }

            if (string.IsNullOrWhiteSpace(ModeloIngresado))
            {
                return string.Empty;
            }

            if (ModeloIngresado.Length > 30)
            {
                return "El modelo debe tener menos de 30 caracteres";
            }

            if (!int.TryParse(AñoIngresado, out int anioIngresado))
            {
                return "Debe ingresar un dato numerico";
            }

            if (anioIngresado <= 2000 || anioIngresado > DateTime.Now.Year)
            {
                return "El año debe ser un número de 4 dígitos y estar dentro del rango válido";
            }



            return "Los datos ingresados estan ok";
        }

    }
    }




