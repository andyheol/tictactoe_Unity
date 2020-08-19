# tictactoe_Unity
게임 시연 영상 유튜브 주소 : https://www.youtube.com/watch?v=VOtkPE09ins

두가지 모드의 틱택토 게임

*개발 언어 : C#

*개발도구 : 유니티 엔진,비주얼 스튜디오 

게임씬의 주요 로직 
1. 게임 주요 로직 
* 마우스 클릭 지점에 O,X 이미지를 배치 
* O,X 차례대로 게임 진행 
* 게임의 승부 판정 
* 이미지, Text, 버튼 등 UI 컴포넌트 사용 
* 시간 측정 함수로 게임의 스피드 조절 
* 코루틴 함수로 시간 간격 조절 
* 승부 판정 후 득점처리 
* 랜덤으로 중복되지 않은 자리에 O,X 객체 배치
* 마우스 중복 클릭 판정 후 처리

2. 토글 스위치로 single/double 모드 선택
* single 모드 : 컴퓨터와 사용자1의 대결 
* Double모드 : 사용자1과 사용자2의 대결
* playerprefs 클래스를 사용하여 게임 모드 기억한 후 게임 모드 변경시 게임 다시 불러오기 
* 재시작 버튼 클릭시 게임 다시 불러오기 
