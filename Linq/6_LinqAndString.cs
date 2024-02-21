using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class LinqToHandleString
    {
        public static void CountApperance(string source, string searchTerm)
        {
            //RemoveEmptyEntries là bỏ phan tu trắng
            string[] datas = source.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Tạo truy vấn LINQ  
            // Dùng phương thức ToLowerInvariant để so khớp hoa thường cụm từ là như nhau
            // Ví dụ: "hiepsiIT" và "hiepsiit" 
            var matchQuery = from word in datas
                             where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                             select word;

            // Đếm số từ khóa tìm thấy và trả về kết quả
            int matchCount = matchQuery.Count();

            Console.WriteLine("Tim thay tu khoa \"{0}\" xuat hien {1} lan trong doan van ban.", searchTerm, matchCount);
        }

        public static void CountNumberOfWordInSource(string source)
        {
            //RemoveEmptyEntries là bỏ phan tu trắng
            string[] datas = source.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("So tu trong doan van ban la: " + datas.Length);
        }

        public static void FindSentencesContainsArrayWords(string source, string[] arrayWords)
        {
            // Tách đoạn văn bản thành các câu
            // Một câu thường kết thúc bằng dấu chấm, chấm hỏi và dấu chấm than.
            string[] sentences = source.Split('.', '?', '!');

            // Tìm các câu chứa tất cả từ trong mảng wordsToMarch
            // ToLowerInvariant() cho phép phân biệt hoa, thường
            var sentenceQuery = from sentence in sentences
                                let words = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries) // tach tu
                                where words.Distinct().Select(x => x.ToLowerInvariant()).Intersect(arrayWords.Select(x => x.ToLowerInvariant())).Count() == arrayWords.Count()
                                select sentence;

            Console.WriteLine("Cac tu khoa tim kiem: \"{0}\"", string.Join(",", arrayWords));
            Console.WriteLine("Cac cau co chua cac tu khoa nay:");
            foreach(var sentence in sentenceQuery)
            {
                Console.WriteLine(sentence);
            }
        }

        public static void GetNumberInString(string source)
        {
            // chọn các ký tự là số trong chuỗi  
            IEnumerable<char> stringQuery =
              from ch in source
              where Char.IsDigit(ch)
              select ch;

            // Thực thi truy vấn, xuất kết quả các ký tự là số
            foreach (char c in stringQuery)
                Console.Write(c + " ");

            // Đếm số ký tự là số tìm được 
            Console.WriteLine(" --- So ky tu la so = {0}", stringQuery.Count());
        }

        public static void GetTheFirstPart(string source, char separator)
        {
            // Chọn tất cả ký tự trước dấu gạch ngang '-'
            IEnumerable<char> stringQuery = source.TakeWhile(c => c != separator);

            // Thực thi truy vấn, xuất kết quả các ký tự là số
            foreach (char c in stringQuery)
                Console.Write(c + "");
        }
    }
}
