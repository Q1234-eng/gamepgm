상수,변수
연산자
제어문
배열
포인터(메모리를 조작할수 있는 변수)
함수 
구조체(파일을 다루게 해준다)



25(줄) * 80(칸) ->텍스트 모드

@ 오타 <conin.h> 를 <window.h>로 수정

#include <stdio.h> 사용이유 입력하거나 출력하기위해 

Printf 를 사용헐려면 어떤일을 하는지 명령이 필요하다. 기계어로 바꾸는건 comfile 


<windows.h>

Coord 데이터 타일 pos라는 변수 = {x - 1, y - 1};
 ->변수를 만들기 위한게 데이터 타일이다.

Getsthanlde 위에 정해저있는 함수

Cmd에서 사용할수있는 cls를 c언어에서 system이라는 명령어를 사용하여 사용할수 있게 해준다
char a[20];
a + "abcd"

printf("%s", a);
-> %s 주소로가서 문자열 끝까지 출력함
int printf(const char *format, ...)

printf prototype
printf는 출력하고 다시 돌려준다.


int main()
{ 
	char string[20]= "abcd";
	
	int i;
	
	printf("%d\n", sizeof(string));
	i = printf("%s", string); 
	printf("%d\n", i);
	\
	
	return 0;
}

int scanf(const char *format, ...);
 
->  scanf("%c", &c);를 scanf(" %c", &c); 로%c 앞에 공백을 추가하면 white space를 구분자로 인식한다

#include <stdio.h>
 #include <conio.h>
 int main(void)
 {
 int chr;
 do
 {
 chr=getch(); -> 확장코드에는 꼭 필요하다
 if (chr==0 || chr == 0xe0)
 {
 chr=getch();
 printf("확장키 code=%d\n", chr);
 }
 else
 printf("아스키 code=%d\n", chr);
 }while(1);
 return 0;
 }

ctrl과 shift는 독자적으로 사용 할 수 없으나 alt는 메뉴키로 사용되어 사용 가능

키보드에서 인식하는건 확장키랑 아스키 코드이다.

ASCII, 확장 ASCII 코드

 printf("%c%c",a, b[3]); %c가 두개 있어야 2bit가 출력됨

 32열 printf(" "); 안에 공백에 따라 선 위치가 달라짐

((c=sub_menu_display01() 의 리턴값이 
 printf("햄버거 만들기\n\n");
 printf("1. 치킨버거\n");
 printf("2. 치즈버거\n");
 printf("3. 메인 메뉴로 이동\n\n");
 printf("메뉴번호 입력>");

=getch()-48 의 48은
-> '0' = 30h = 48 문자 숫자 기억하기

1.chat gpt 써서 문제확인하기

2.docs.oracle.com/en/ 들어가서 확인하기
-> java technical documation->java api documation -> search 

srand(time(NULL)); -> srand(1); 
time(NULL)-> 현재 시간에 따라 랜덤함수 정수가 정해지므로 실행때 마다 결과가 달라진다.

prototype signiture 
-> prototype은 int printf( , )이고 int를 뺀 printf( , )를 signiture라 부른다.
int abc , double abc 를 오버로딩할떄 signiture 가 같으므로 보지않는다

if (lotto[i] == lotto[j])
 {
 i--;
 break;
-> 같은게 나오면 한번 더 돌리게 해준다.

 doublesum(intcount, ...); <- 매개변수

{
 printf("합계= %lf\n", sum(2, 10.5, 20.23)); <- 전달값



