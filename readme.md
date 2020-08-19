# AstroN Auto Tune

모바일게임인 아스트로엔이라는 게임의 아이템개조를 자동으로 해주는 매크로 프로그램입니다.
블루스택 자체적으로 키보드 또는 마우스를 반복 입력하는 매크로 프로그램이 내장되어 있지만, 개조가 성공했는지, 실패했는지 여부는 판단할 수 없기 때문에 만들게 되었습니다.

아이템 개조 이후 텍스트보드를 캡쳐하고, Tesseract OCR을 이용해 캡쳐된 이미지내 문자를 추출하여 개조 성공여부를 판단하여 다음 플랜을 결정하게 됩니다. 또한 WIndow Handler를 이용하여 실행된 블루스택 내부에서만 작동되기 때문에 매크로를 켜둔 상태로 다른 행동을 할 수 있습니다.

[![Video Label](http://img.youtube.com/vi/6UGx64RDpEE/0.jpg)](https://youtu.be/6UGx64RDpEE)

## 버전정보
- Visual Studio 2015
- Windows Forms
- Tesseract 3.3.0
- BluStack App Player 4.220.0.1109


## 추가 개발 리스트 목록
- [ ] 소스 정리 (객체지향)
- [ ] 이미지 캡쳐 핸들링
- [ ] 핸들러 서치
