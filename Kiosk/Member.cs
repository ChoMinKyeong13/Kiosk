using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public  class Member
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public int Points { get; set; }
        public string Grade { get; set; }
        public DateTime? Birthday { get; set; }
        public string Tel { get; set; }

        // 조회 결과가 없을 때 등, 빈 회원 객체가 필요할 때 사용
        public static Member Empty()
        {
            return new Member
            {
                MemberId = "",
                Name = "",
                Points = 0,
                Grade = "일반"
            };
        }
    }
}
