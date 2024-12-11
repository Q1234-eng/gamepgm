# 제작 내용


### 시연 영상
-**`play`**
-[play](https://youtu.be/gekN1plq25I)

---

### 구현 목록
- **Player 기능 구현**
  - Player 움직임 구현
  - Player 체력 구현
  - Player 애니메이션 구현
  - Player 공격 구현
  - Bullet 데미지 구현
- **Enemy 기능 구현**
  - Enemy 움직임 구현
  - Enemy 체력 구현
  - Enemy 애니메이션 구현
  - Enemy 스폰 구현
  - Enemy 공격 구현
- **UI 및 게임 관리**
  - Player 체력 UI 구현
  - Game Over UI 제작
  - Restart 기능 구현
  - Player 사망 시 화면 배경 변경 구현
  - 게임 시작 버튼 및 Start 버튼 구현

---

### 코드 정리
- **`GameManager.cs`**
  - Player 이동, 체력, 공격, 게임 플레이어 상태 관리, 사망 시 화면 애니메이션(작동 O), 공격 사운드 처리
- **`Enemy.cs`**
  - Enemy AI 제어 및 움직임, 체력 관리, 스폰 처리
- **`BackGround.cs`**
  - 배경 화면 관리
- **`MainMenu.cs`**
  - 게임 스타트 버튼 로직
- **`Spawner.cs`**
  - Enemy가 설정한 초단시간마다 소환되도록 구현
- **`TargetFallow.cs`**
  - Enemy가 Player를 따라다니도록 설정
- **`PoolManager.cs`**
  - Pooling System 적용 (현재 미완성)

---

### 사용 리소스
- **에셋 리소스**
  - [고스위치 캐릭터](https://assetstore.unity.com/packages/2d/characters/gothicvania-swamp-152865)
- **사운드**
  - [배경음](https://freesound.org/people/Mrthenoronha/sounds/653527/)
  - [총소리](https://freesound.org/people/LittleRobotSoundFactory/sounds/270343/)
- **참고 자료**
  - [YouTube 링크](https://www.youtube.com/watch?v=MmW166chj54&list=PLo-mt5lu5TeZf8wMHgT_DHApkMjf6i3ix)

---

### Prompt

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


---
