# tictactoe_Unity
유니티 프로젝트
개발 언어 : C# 개발도구:유니티엔진,비주얼스튜디오 
게임씬의주요로직 
1. 게임 주요 로직 
*마우스클릭지점에게임의O, X이미지를배치  
*O, X 차례대로 게임 진행  
*게임의승부판정  
*이미지, Text, 버튼 등 UI컴포넌트사용  
*시간측정함수로게임의스피드조절  
*코루틴함수로시간간격조절  
*승부판정후득점처리  
*랜덤으로중복되지않은자리에O, X객체배치  
*마우스 중복클릭판정후처리  

2. 토글 스위치로 single/double 모드 선택
single 모드 : 컴퓨터와 사용자1의 대결 
Double모드:사용자1과사용자2의대결 
playerprefs 클래스를 사용하여 게임 모드 기억한 후 게임모드전환시게임다시불러오기 
재시작 버튼 클릭시 게임 다시 불러오기 
