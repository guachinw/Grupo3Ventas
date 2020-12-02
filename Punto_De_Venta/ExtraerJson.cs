using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Punto_De_Venta
{
    class ExtraerJson
    {
		private List<string[]> Conversiones { get; } = new List<string[]>
		{
			new string[]
			{
				"Â",
				""
			},
			new string[]
			{
				"Â¡",
				"¡"
			},
			new string[]
			{
				"Â¢",
				"¢"
			},
			new string[]
			{
				"Â£",
				"£"
			},
			new string[]
			{
				"Â¤",
				"¤"
			},
			new string[]
			{
				"Â¥",
				"¥"
			},
			new string[]
			{
				"Â¦",
				"¦"
			},
			new string[]
			{
				"Â§",
				"§"
			},
			new string[]
			{
				"Â¨",
				"¨"
			},
			new string[]
			{
				"Â©",
				"©"
			},
			new string[]
			{
				"Âª",
				"ª"
			},
			new string[]
			{
				"Â«",
				"«"
			},
			new string[]
			{
				"Â",
				""
			},
			new string[]
			{
				"Â­",
				"­"
			},
			new string[]
			{
				"Â®",
				"®"
			},
			new string[]
			{
				"Â¯",
				"¯"
			},
			new string[]
			{
				"Â°",
				"°"
			},
			new string[]
			{
				"Â±",
				"±"
			},
			new string[]
			{
				"Â²",
				"²"
			},
			new string[]
			{
				"Â³",
				"³"
			},
			new string[]
			{
				"Â´",
				"´"
			},
			new string[]
			{
				"Âµ",
				"µ"
			},
			new string[]
			{
				"Â",
				""
			},
			new string[]
			{
				"Â·",
				"·"
			},
			new string[]
			{
				"Â¸",
				"¸"
			},
			new string[]
			{
				"Â¹",
				"¹"
			},
			new string[]
			{
				"Âº",
				"º"
			},
			new string[]
			{
				"Â»",
				"»"
			},
			new string[]
			{
				"Â¼",
				"¼"
			},
			new string[]
			{
				"Â½",
				"½"
			},
			new string[]
			{
				"Â¾",
				"¾"
			},
			new string[]
			{
				"Â¿",
				"¿"
			},
			new string[]
			{
				"Ã€",
				"À"
			},
			new string[]
			{
				"Ã\u0081",
				"Á"
			},
			new string[]
			{
				"Ã‚",
				"Â"
			},
			new string[]
			{
				"Ãƒ",
				"Ã"
			},
			new string[]
			{
				"Ã„",
				"Ä"
			},
			new string[]
			{
				"Ã…",
				"Å"
			},
			new string[]
			{
				"Ã†",
				"Æ"
			},
			new string[]
			{
				"Ã‡",
				"Ç"
			},
			new string[]
			{
				"Ãˆ",
				"È"
			},
			new string[]
			{
				"Ã‰",
				"É"
			},
			new string[]
			{
				"ÃŠ",
				"Ê"
			},
			new string[]
			{
				"Ã‹",
				"Ë"
			},
			new string[]
			{
				"ÃŒ",
				"Ì"
			},
			new string[]
			{
				"Ã\u008d",
				"Í"
			},
			new string[]
			{
				"ÃŽ",
				"Î"
			},
			new string[]
			{
				"Ã\u008f",
				"Ï"
			},
			new string[]
			{
				"Ã\u0090",
				"Ð"
			},
			new string[]
			{
				"Ã‘",
				"Ñ"
			},
			new string[]
			{
				"Ã’",
				"Ò"
			},
			new string[]
			{
				"Ã“",
				"Ó"
			},
			new string[]
			{
				"Ã”",
				"Ô"
			},
			new string[]
			{
				"Ã•",
				"Õ"
			},
			new string[]
			{
				"Ã–",
				"Ö"
			},
			new string[]
			{
				"Ã—",
				"×"
			},
			new string[]
			{
				"Ã˜",
				"Ø"
			},
			new string[]
			{
				"Ã™",
				"Ù"
			},
			new string[]
			{
				"Ãš",
				"Ú"
			},
			new string[]
			{
				"Ã›",
				"Û"
			},
			new string[]
			{
				"Ãœ",
				"Ü"
			},
			new string[]
			{
				"Ã\u009d",
				"Ý"
			},
			new string[]
			{
				"Ãž",
				"Þ"
			},
			new string[]
			{
				"ÃŸ",
				"ß"
			},
			new string[]
			{
				"Ã",
				"à"
			},
			new string[]
			{
				"Ã¡",
				"á"
			},
			new string[]
			{
				"Ã¢",
				"â"
			},
			new string[]
			{
				"Ã£",
				"ã"
			},
			new string[]
			{
				"Ã¤",
				"ä"
			},
			new string[]
			{
				"Ã¥",
				"å"
			},
			new string[]
			{
				"Ã¦",
				"æ"
			},
			new string[]
			{
				"Ã§",
				"ç"
			},
			new string[]
			{
				"Ã¨",
				"è"
			},
			new string[]
			{
				"Ã©",
				"é"
			},
			new string[]
			{
				"Ãª",
				"ê"
			},
			new string[]
			{
				"Ã«",
				"ë"
			},
			new string[]
			{
				"Ã",
				"ì"
			},
			new string[]
			{
				"Ã­",
				"í"
			},
			new string[]
			{
				"Ã®",
				"î"
			},
			new string[]
			{
				"Ã¯",
				"ï"
			},
			new string[]
			{
				"Ã°",
				"ð"
			},
			new string[]
			{
				"Ã±",
				"ñ"
			},
			new string[]
			{
				"Ã²",
				"ò"
			},
			new string[]
			{
				"Ã³",
				"ó"
			},
			new string[]
			{
				"Ã´",
				"ô"
			},
			new string[]
			{
				"Ãµ",
				"õ"
			},
			new string[]
			{
				"Ã",
				"ö"
			},
			new string[]
			{
				"Ã·",
				"÷"
			},
			new string[]
			{
				"Ã¸",
				"ø"
			},
			new string[]
			{
				"Ã¹",
				"ù"
			},
			new string[]
			{
				"Ãº",
				"ú"
			},
			new string[]
			{
				"Ã»",
				"û"
			},
			new string[]
			{
				"Ã¼",
				"ü"
			},
			new string[]
			{
				"Ã½",
				"ý"
			},
			new string[]
			{
				"Ã¾",
				"þ"
			},
			new string[]
			{
				"Ã¿",
				"ÿ"
			}
		};
		private string EquivalenciaUtF8(string dato)
		{
			string text = dato;
			foreach (string[] array in this.Conversiones)
			{
				bool flag = text.Contains(array[0]);
				if (flag)
				{
					text = text.Replace(array[0], array[1]);
				}
			}
			return text;
		}
		public Compania GetContribuyente(string Ruc)
		{
			Compania compania = null;
			try
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://dni.optimizeperu.com/api/company/" + Ruc + "?format=json");
				bool flag = text.Length > 3;
				if (flag)
				{
					string[] array = text.Split(new string[]
					{
						"\",\""
					}, StringSplitOptions.None);
					array[0] = array[0].Replace("{", "");
					array[array.Length - 1] = array[array.Length - 1].Replace("}", "");
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = array[i].Replace("\"", "");
					}
					compania = new Compania
					{
						Ruc = array[0].Split(new char[]
						{
							':'
						})[1],
						Razon_social = array[1].Split(new char[]
						{
							':'
						})[1],
						Ciiu = array[2].Split(new char[]
						{
							':'
						})[1],
						Fecha_actividad = DateTime.Parse(array[3].Split(new char[]
						{
							':'
						})[1]),
						contribuyente_condicion = array[4].Split(new char[]
						{
							':'
						})[1],
						contribuyente_tipo = array[5].Split(new char[]
						{
							':'
						})[1],
						contribuyente_estado = array[6].Split(new char[]
						{
							':'
						})[1],
						nombre_comercial = array[7].Split(new char[]
						{
							':'
						})[1],
						fecha_inscripcion = DateTime.Parse(array[8].Split(new char[]
						{
							':'
						})[1]),
						domicilio_fiscal = array[9].Split(new char[]
						{
							':'
						})[1],
						sistema_emision = array[10].Split(new char[]
						{
							':'
						})[1],
						sistema_contabilidad = array[11].Split(new char[]
						{
							':'
						})[1],
						actividad_exterior = array[12].Split(new char[]
						{
							':'
						})[1],
						emision_electronica = array[13].Split(new char[]
						{
							':'
						})[1],
						fecha_inscripcion_ple = array[14].Split(new char[]
						{
							':'
						})[1],
						oficio = array[15].Split(new char[]
						{
							':'
						})[1],
						fecha_baja = array[15].Split(new char[]
						{
							':'
						})[2],
						Representante_legal = array[16],
						locales = array[18].Split(new char[]
						{
							':'
						})[1]
					};
					compania.domicilio_fiscal = this.EquivalenciaUtF8(compania.domicilio_fiscal);
					compania.nombre_comercial = this.EquivalenciaUtF8(compania.nombre_comercial);
					compania.Razon_social = this.EquivalenciaUtF8(compania.Razon_social);
					bool flag2 = compania.oficio.ToString().Contains("null");
					if (flag2)
					{
						compania.oficio = null;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return compania;
		}


	}
}
