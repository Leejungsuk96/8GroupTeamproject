## :heart: 8조 똥피하기 게임소개<br/><br/>
고전게임 똥피하기를 기반으로 우리 팀만의 게임 개발
<br/><br/>
<br/><br/>




## :orange_heart:개발 환경/ 에셋소스
Unity Ver: 2022.3.2f1<br/><br/>
IDE : Vs Code <br/><br/>
Asset 출처 <br/><br/>
&nbsp;- 써니랜드(에셋스토어): https://assetstore.unity.com/packages/2d/characters/sunny-land-103349 <br/><br/>
&nbsp;- 태백체폰트: https://www.taebaek.go.kr/www/contents.do?key=1857 <br/><br/>
&nbsp;- 판타지 우든GUI: https://assetstore.unity.com/packages/2d/gui/fantasy-wooden-gui-free-103811 

<br/><br/><br/><br/>

## :yellow_heart:Wireframe
![image](https://github.com/Leejungsuk96/8GroupTeamproject/assets/114940193/e4043729-bd00-42f1-99bf-bff9367f7f15)

<br/><br/><br/><br/>

## :green_heart:팀원 역할분담<br/><br/>
팀장(총괄디렉터): 조현근- 플레이어 상호작용 아이템 제작<br/><br/>
팀원(메인프로그래머): 박민규- 하늘에서 떨어지는 Poop 기획 및 구현 + 충돌 후 반응 구현<br/><br/>
팀원(프로그래머): 김수아- 캐릭터 움직임(좌,우,점프) 기획 및 구현 + 애니메이션 추가<br/><br/>
팀원(프로그래머): 이정석- MenuScene 제작 + 최고점수, 게임 시간, EndPanel 제작<br/><br/>
팀원(디자이너): 이원재- IntroScene 제작 + 오디오 관리 + 에셋디자인 및 관리
<br/><br/><br/><br/>
-진행상황 공유
![image](https://github.com/Leejungsuk96/8GroupTeamproject/assets/114940193/2e77465f-2609-413e-9938-56ae29be4567)
<br/><br/>
-Github 관리
![image](https://github.com/Leejungsuk96/8GroupTeamproject/assets/114940193/98ca946c-958a-4c8a-a62e-0814524b8b00)

<br/><br/><br/><br/>

## :blue_heart:주요기능<br/><br/>
1. Poop과 플레이어와 충돌 감지해서 게임종료/ 벽과 충돌 감지해서 점수계산<br/><br/>
2. 알약과 플레이어와 충돌 감지해서 무적 효과 발생<br/><br/>
3. Prefebs Pool 방식으로 관리<br/><br/>
4. 오디오 매니저 씬 이동해도 유지 / 씬마다 오디오 매니저에서 오디오 소스 가져오기

<br/><br/><br/><br/>

## :purple_heart:문제 및 해결
1. private로 설정 했을 때 NullRefence 오류시<br/><br/>
- public으로 바꾸지 않고 GetComponent<>/ GetComponentChildren<>/GetComponentParent<>로 필요한 컴포넌트 가져오기<br/><br/>
2. 플레이어가 점프해서 양쪽벽에 부딪혔을때 벽에 붙는현상<br/><br/>
3. Instansiate 와 Destroy를 이용하여 게임오브젝트를 생성했는데 데이터 계속 쌓여서 메모리 효율이 저하 된다고 생각<br/><br/>
- Instansiate 와 Destroy 대신에 Pool방식으로 변환하여 게임오브젝트를 재활용하여 메모리 효율을 올림<br/><br/>
4. AudioManager 씬이동 시 파괴 /효율적인 오디오 소스 관리<br/><br/>
- DontDestoryOnLoad를 사용하여 오디오 매니저가 없어지지 않게 하고 싱글톤화 시켜줘소 필요시 오디오 매니저에서 가져와서 사용함<br/><br/>
