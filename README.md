# jayceIOSTexTest
iOS 에서 NPOT/POT 텍스쳐 메모리 할당 테스트용 

- xCode 로 빌드해서 Run 및 씬 바꿔가면서 테스트 GO

NoPacking , Legacy Packing , Sprite Atlas Packing 으로 나누어서 
각각 NPOT/POT 테스트함 . 

<결과>

  <b>Xcode 의 instruments 가 아닌 , Debug Navigator 로 테스트함 .</b>

  NPOT (모든씬빌드)
    - packing X : 90.3 MB 
    - packing legacy 
    - 에디터서 legacy enabled 일때 79 MB
    - spriteAtlas 가 enabled 일때 90.2 MB
    - packing atlas
    - 에디터서 legacy Enabled 일때 75.2 MB
    - 에디터서 sprite Atlas enabled 일떄 77 MB 

  POT (모든씬빌드)
    - packing X : 79.1 MB
    - packing legacy
    - 에디터서 legacy enabled 일때 79.1 MB
    - spriteAtlas 가 enabled 일때 93 MB 
    - packing atlas 
    - 에디터서 legacy enabled 일떄 75.2 MB
    - spriteAtlas 가 enabled 일때 77 MB

  npot,pot(패킹안되어있는 씬 2개만 빌드)
    - packing X : 86.5 MB
    - packing O : 75.2 MB
    - 즉 씬빌드 영향있음 . 빌드에 씬을 더 포함하니
    메모리 사용량 증가함. 

  - 에디터에서의 sprite packing 옵션이 영향을 주는거로 보임 
  legacy 가 극명하게 차이남 
