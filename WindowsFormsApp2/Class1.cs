using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Music_Albums_Base
{
    /// <summary>
    /// Добавление альбомов
    /// </summary>
    public class AddingAlbums
    {
        /// <summary>
        /// Список альбомов
        /// </summary>
        public List<Album> Albumlist { get; set; }
    }

    /// <summary>
    /// Добавление артиста
    /// </summary>
    public class AddingArtist
    {
        /// <summary>
        /// Список артистов
        /// </summary>
        public List<Artist> Artistlist { get; set; }
    }

    /// <summary>
    /// Класс артиста
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Список работ
        /// </summary>
        public string About { get; set; }

        internal DialogResult ShowDialog(Form1 form1)
        {
            throw new NotImplementedException();
        }
        

        /// <summary>
        /// Музыкальные жанры
        /// </summary>
        /// 
        public static List<string> MusicGenres = new List<string>()
        {
            "Rock", "EDM", "Jazz", "Blues", "Rap", "R&B", "Pop",
            "Classical", "House", "Techno", "Metal", "Hip-Hop",
            "Synthwave", "Shanson", "Epic", "Commercial", "Другое"
        };

        /// <summary>
        /// Жанр
        /// </summary>
        public string MusicGenre { get; set; }

        public override string ToString()
        {
            return $"Артист: {NickName} , Дата рождения: {DOB} , Информация: {About} , Музыкальный жанр: {MusicGenre}";
        }

    }
    /// <summary>
    /// Класс альбома
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Название альбома
        /// </summary>
        public string AlbumName { get; set; }
        /// <summary>
        /// Продолжительность
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// Год выпуска
        /// </summary>
        public DateTime Year { get; set; }
        internal DialogResult ShowDialog(Form1 form1)
        {
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Список жанров
        /// </summary>
        public static List<string> MusicGenres = new List<string>()
        {
            "Rock", "EDM", "Jazz", "Blues", "Rap", "R&B", "Pop",
            "Classical", "House", "Techno", "Metal", "Hip-Hop",
            "Synthwave", "Shanson", "Epic", "Commercial", "Другое"
        };

        /// <summary>
        /// Жанр
        /// </summary>
        public string MusicGenre { get; set; }

        public override string ToString()
        {
            return $"Название альбома: {AlbumName} , Год выпуска: {Year} , Продолжительность: {Duration}  , Жанр: {MusicGenre}";
        }

    }

}