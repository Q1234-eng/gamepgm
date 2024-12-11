제작 - 17
맵 제작
player 움직임 구현
player 체력 구현
player 애니메이션 구현
player 공격 구현
bullet 데미지 구현
enemy 움직임 구현
enemy 체력 구현
enemy ai 구현
enemy 애니메이션 구현
enemy 공격 구현
enemy 스폰 풀 구현
player 체력 ui 구현
gameover ui 제작과 restart 기능 구현
player 사격 사운드 구현
게임배경음악 구현
게임 시작 메뉴 구현 및 start 버튼 구현

코드 정리
-player.cs >> player 이동, 체력, 공격, 구현, 플레이어 상태관련 UI, 사망사운드와 애니메이션(작동 x), 공격 사운드
-GameManager.cs >> 게임 재시작 구현
-enemy.cs >> enemy ai, 체력, 공격, 사망 애니메이션(작동 x)
-Bullet.cs >> 총알 데미지 판정과 수치
-BackGround.cs >> 배경 음악
-Mainmenu.cs >> 게임 스테이지로 넘어가는 버튼 구현
-Spwaner.cs >> enemy가 설정한 스폰시간 마다 소환 되도록 구현
-TargetFallow.cs >> enemy가 player를 따라가도록 설정한 ai
-PoolManager.cs (작동 안함)

https://assetstore.unity.com/packages/2d/characters/gothicvania-swamp-152865 에셋사용
https://freesound.org/people/Mrthenoronha/sounds/653527/ 배경음
https://freesound.org/people/LittleRobotSoundFactory/sounds/270343/ 총소리
https://www.youtube.com/watch?v=MmW166cHj54&list=PLO-mt5Iu5TeZF8xMHqtT_DhAPKmjF6i3x 참고자료

prompt

enemy 스폰 코드 짜줘
그냥 앞으로만 가고 싶은데 이렇게 돌아 캐릭터가 있는데 앞뒤로 움직이고 점프하는 코드 짜줘 유니티야
시작하니까 캐릭터가 작아져
좌우로만 움직이면서 플래이어 따라 다니는 코드 짜줘
플래이어 방향에 따라 flip 됬으면 좋겠어
shoot에 좌클릭할떄 나가는 모션 주고 싶은데 뭘 추가해야해
총알이 플레어가 보는 방향으로 나가게 해줘
enemy가 bullet을 맞아도 안죽고 그냥 통과해
player랑 enemy가 닿아도 player가 아무런 반응이 없어
canvas에 text(tmp)를 추가 했어 player 체력이 나오면 좋겠어
player가 죽으면 gameover라고 뜨게 해줘 빨간글씨로
enemy가 한번 데미지 주고 끝나는데 지속적으로 주게 할수 있어?
restart 버튼 만들어줘
이런 풍의 게임 일러스트 1920 1080으로 뽑아줘
주인공이 총들고 있으면 좋겠고 배경이 정글이였으면 좋겠어 좀 더 어두운 분위여야해
1920 1080으로 뽑아줘
게임 배경음은 어떻게 추가해?
player가 총쏠때 소리나게해줘
플래이어가 죽으면 배경음도 꺼지게 해줘
