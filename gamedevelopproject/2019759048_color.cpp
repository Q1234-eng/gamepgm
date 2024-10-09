#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>
#include <conio.h>

#define cake_number 30  // ������ ���� 

void intro_game(void);
void input_participant(char user_name[][8]);
void game_control(char name[][8], int condition[], int *left, int user, int *start, int *end);
void cake_display(char name[][8], int condition[], int left, int start, int end);
void gotoxy(int x, int y);
void set_color(int color);

int main(void)
{
    int i, start, end, cake_left, winner;
    int cake_condition[cake_number];
    char user_name[2][8];
    char restart;

    do {
        srand(time(NULL));
        intro_game();
        input_participant(user_name);

        cake_left = cake_number;
        for (i = 0; i < cake_number; i++) {
            cake_condition[i] = 0;
        }
        start = 0;
        end = cake_number - 1;

        system("cls");
        game_control(user_name, cake_condition, &cake_left, 2, &start, &end);
        gotoxy(10, 12);
        printf("�ƹ�Ű�� ������ ���� ������ �����մϴ�. ");
        getch();

        do {
            for (i = 0; i < 2; i++) {
                system("cls");
                game_control(user_name, cake_condition, &cake_left, i, &start, &end);
                if (cake_left < 2) {
                    winner = i;
                    break;
                }
                gotoxy(10, 12);
                printf("�ƹ�Ű�� ������ ���� ������ �����մϴ�. ");
                getch();
            }
        } while (cake_left > 2);

        set_color(11);
        gotoxy(10, 12);
        printf("%s���� �̰���ϴ�. ", user_name[winner]);
        gotoxy(10, 13);
        printf("������ �����մϴ�. \n");

        set_color(11);
        gotoxy(10, 15);
        set_color(12);
        printf("������ ������Ϸ��� 'R'�� �����ʽÿ�. �����Ϸ��� �ƹ� Ű�� ��������. ");
        restart = getch();

    } while (restart == 'R' || restart == 'r');

    return 0;
}

void intro_game(void)
{
    system("cls");
    set_color(7);
    printf("�ֻ����� ���ڸԱ� ���� \n\n");
    printf("�λ���� ���� �糡�� �ֻ��� ���ڸ�ŭ\n");
    printf("���ڸ� �Դ� �����Դϴ�. \n");
    printf("������ ���� ���ڸ� �Դ� ����� �̱�ϴ�. \n\n");
    printf("�ƹ�Ű�� ������ ���������ڸ�\n");
    printf("�Է��մϴ�.\n");
    set_color(7);
    getch();
}

void input_participant(char user_name[][8])
{
    system("cls");
    set_color(11); 
    printf("1�� �������� �̸��� �Է��ϰ� Enter>");
    scanf("%s", user_name[0]);
    printf("2�� �������� �̸��� �Է��ϰ� Enter>");
    scanf("%s", user_name[1]);
    set_color(7);
    printf("�ƹ�Ű�� ������ ������ �����մϴ�...");
    getch();
}

void game_control(char name[][8], int condition[],  int *left, int user, int *s, int *e)
{
    int i, dice_number;
    cake_display(name, condition, *left, *s, *e);

    if (user == 2)
        return;

    dice_number = rand() % 6 + 1;
    *left -= dice_number;
    gotoxy(10, 11);
    set_color(12);
    printf("%s���� �ֻ��� ���ڴ� %d�Դϴ�.", name[user], dice_number);

    if (user == 0) {
        for (i = *s; i < dice_number + *s; i++)
            condition[i] = 1;
        *s += dice_number;
    } else {
        for (i = *e; i > (*e - dice_number); i--)
            condition[i] = 1;
        *e -= dice_number;
    }
    cake_display(name, condition, *left, *s, *e);
}

void cake_display(char name[][8], int condition[], int left, int s, int e)
{
    int i;
    char *eat_cake = "��", *remain_cake = "��";

    gotoxy(30, 5);
    if (left < 0)
        left = 0;
    set_color(7);
    printf("���� ������ �� : %2d �� ", left);

    for (i = 0; i < 2; i++) {
        gotoxy(i * 50 + 10, 6);
        printf("%s", name[i]);
    }

    for (i = 0; i < 30; i++)
        if (condition[i] == 1) {
            gotoxy(10 + i * 2, 8);
            printf("%s", eat_cake);
        } else {
            gotoxy(10 + i * 2, 8);
            printf("%s", remain_cake);
        }

    gotoxy(10, 9);
    printf("���� ���� ��: %2d", s);
    gotoxy(52, 9);
    printf("���� ���� ��: %2d", 29 - e);
}

void gotoxy(int x, int y)
{
    COORD Pos = {x - 1, y - 1};
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), Pos);
}

void set_color(int color)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), color);
}

