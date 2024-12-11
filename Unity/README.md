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
1. Enemy 스폰 코드를 짜되, 앞으로만 가고 싶으면 이동키 없이 앞뒤로 움직이고 점프하는 코드 작성.
2. Unity에서 캐릭터가 자동으로 움직이되 Player가 점프 시 조작 가능하도록.
3. Enemy를 추가하면서 총알이 Player를 추적하도록 구현.
4. `Canvas` UI와 `Text`를 활용해 Player 사망 시 "Game Over" 표시.
5. 게임의 배경화면 해상도를 1920x1080으로 변경하고 Player가 죽으면 배경화면도 함께 변경되도록 추가.
6. 총소리와 배경음악의 볼륨을 조정해 배경음악은 Player 사망 시 꺼지도록 처리.

---

