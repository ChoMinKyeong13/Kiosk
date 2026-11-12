# Kiosk — 분식/패스트푸드 주문 키오스크

C# WinForms로 만든 매장 주문 키오스크 앱입니다. (개인 프로젝트, 모블 국비과정)

## 기술 스택
- C# / .NET 6 WinForms

## 주요 기능
- 카테고리별 메뉴: 버거, 라면, 밥, 분식, 음료, 아이스크림
- 장바구니 담기 / 수량 변경 / 합계 계산
- 결제 화면, 카드 결제 화면
- 회원 등록(회원번호·이름·전화번호), 포인트 조회

## 구조
| 파일 | 역할 |
|---|---|
| `Product.cs`, `Productstore.cs` | 상품 모델 / 상품 목록 |
| `Cartstore.cs`, `Cartform.cs` | 장바구니 |
| `Member.cs`, `Memberstore.cs`, `Register.cs` | 회원·포인트 |
| `PaymentForm.cs`, `CardPaymentForm.cs` | 결제 |
| `*Form.cs` | 카테고리별 메뉴 화면 |

## 실행 방법
Visual Studio 2022에서 `Kiosk.sln` 열고 F5.
