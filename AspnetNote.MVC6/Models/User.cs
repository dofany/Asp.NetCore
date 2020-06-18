using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AspnetNote.MVC6.Models
{
    public class User
    {
        [Key] //pk 설정

        /// <summary>
        /// 사용자 번호
        /// </summary>
        public int UserNo { get; set; }
        /// <summary>
        /// 사용자 이름
        /// </summary>
        /// // Not Null 설정
        [Required(ErrorMessage ="사용자 이름을 입력하세요")] 
        public string UserName { get; set; }
        /// <summary>
        /// 사용자 아이디
        /// </summary>
        // Not Null 설정

        [Required(ErrorMessage = "사용자 아이디를 입력하세요")]
        public string UserId { get; set; }
        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        // Not Null 설정

        [Required(ErrorMessage = "사용자 비밀번호를 입력하세요")]
        public string UserPassword { get; set; }
    }
}
