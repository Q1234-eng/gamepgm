# 제작 내용

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

enemy 스폰 코드 짜려 그냥 앞으로만 가고 싶으면 이렇게 하라는 캐릭터가 있는 데  
앞뒤로 움직이고 점프하는 코드 짜줘.

유니티에 시작하니까 캐릭터가 좌우가 자유만 움직이며 플레이어 따라 다니는 거 골라 주면  
점프 있을 경우 `shoot`에 추가 클릭하는 버튼 나오는 모델 추가해 주는데  

추가하게 총알이 플레이어 보는 방향으로 나가는 데 `bullet`을 맞아도 안죽고  
그 상황에서 `enemy`가 달아도 player가 아무런 반응이 없으면  

`canvas`에 `text`따라서 죽음 화면 player 죽으면 "gameover"라고 뜨게 해줘.  

끝나게 준다음에 player가 한 번만 죽고 끝내는 내용 추가해 줘.  

총알의 경우 에셋은 제공 해줌.  

게임의 옵션은 1920 x 1080으로 붙여주는 옵션이  
총소리 있음 좋겠고 배경음 경미 있으면 플랫폼은 설정 해주며  
1920 x 1080으로 붙어서 게임 배경음은 어떻게 추가해?  

player가 총쏘면 소리나는데 플레이어가 죽으면 배경음도 꺼지게 해줘.

---
