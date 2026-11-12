using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    internal class Memberstore
    {
        private static List<Member> members = new List<Member>();

        // 회원번호로 조회 (없으면 null)
        public static Member GetMember(string memberId)
        {
            return members.FirstOrDefault(m => m.MemberId == memberId);
        }

        // 신규 등록 (이미 있으면 false)
        public static bool InsertMember(Member member)
        {
            if (GetMember(member.MemberId) != null)
            {
                return false; // 이미 존재하는 회원번호
            }

            members.Add(member);
            return true;
        }

        // 포인트 적립/차감
        public static bool UpdatePoints(string memberId, int amount)
        {
            var member = GetMember(memberId);
            if (member == null) return false;

            member.Points += amount;
            return true;
        }

        // 전체 회원 목록 (관리자 화면 등에서 필요할 때)
        public static List<Member> GetAllMembers()
        {
            return members;
        }
    }
}
