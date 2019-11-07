using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;

namespace xd
{
	class Audio
	{
		public Audio(string filename)
		{

			Bitrate = 256;
			Filename = filename;
		}

		public override string ToString()
		{
			return $"{Filename} @{Bitrate}kbps";
		}

		~Audio()
		{
		}

		private SFML.Audio.Music Src;
		private string Filename;
		private uint Bitrate;
	}
}
