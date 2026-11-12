<div align="center">

# 🍔 Kiosk

**분식 · 패스트푸드 매장 주문 키오스크**

![C#](https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![.NET 6](https://img.shields.io/badge/.NET%206-WinForms-512BD4?style=flat-square)
![Personal](https://img.shields.io/badge/개인_프로젝트-blue?style=flat-square)

</div>

## 📌 소개
메뉴 선택부터 장바구니, 결제, 회원 포인트까지 실제 매장 키오스크의 주문 흐름을 C# WinForms로 구현했습니다.

## 🧭 화면 흐름
```mermaid
flowchart LR
    A[시작 화면] --> B[카테고리 선택]
    B --> C1[🍔 버거]
    B --> C2[🍜 라면]
    B --> C3[🍚 밥]
    B --> C4[🍢 분식]
    B --> C5[🥤 음료]
    B --> C6[🍦 아이스크림]
    C1 & C2 & C3 & C4 & C5 & C6 --> D[장바구니]
    D --> E[결제]
    E --> F[카드 결제]
    E --> G[회원 등록 · 포인트]
```

## ✨ 주요 기능
- 6개 카테고리 메뉴 화면
- 장바구니 담기 · 수량 변경 · 합계 자동 계산
- 결제 / 카드 결제 화면
- 회원 등록(회원번호 · 이름 · 전화번호, 개인정보 동의) 및 포인트 조회

## 🗂 구조
| 파일 | 역할 |
|---|---|
| `Product.cs` · `Productstore.cs` | 상품 모델 · 상품 목록 |
| `Cartstore.cs` · `Cartform.cs` | 장바구니 데이터 · 화면 |
| `Member.cs` · `Memberstore.cs` · `Register.cs` | 회원 · 포인트 |
| `PaymentForm.cs` · `CardPaymentForm.cs` | 결제 |
| `BurgerForm.cs` 외 5개 | 카테고리별 메뉴 화면 |

## ▶️ 실행 방법
Visual Studio 2022에서 `Kiosk.sln` 열고 `F5`
