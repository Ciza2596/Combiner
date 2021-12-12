Combiner 讓生產效率UpUpUp！
===========================
[Package](https://drive.google.com/file/d/1fhUG40jVvozdLeWcZ0SDbjxQdZLwxCpl/view?usp=sharing)  
.  
.  
Unity 有提供Prefab工具，用起來不是很順手，尤其在生產大量相似的物件的時候。  
.  
像是ABC三種怪，他們的個體差異只有在動畫及數值上，其餘都一摸摸一樣樣。以前的我會先做好A怪然後，複製A兩次，再各別打開Prefab，將其中的動畫及數值換掉。哇～光是這樣想，頭就有點痛了！  
.  
更可怕的還在後頭，如果功能上有些變動，新增了一些Component。這時我有兩條路可以走：  
一，把A怪調整為最新版本後，開始複製大法，然後替換動畫及數值。  
二，把各別舊有的Prefab打開，加入新的Component。  
大家可以試想下，三種怪也許還頂得住，如果有十種怪呢？如果有...停！再想下去我連遊戲都不想做了。  
.  
.  
進入正題，就讓Combiner來拯救你/妳！  
第一步：製作身體架構，請不要放入任何component，這就只是個架構。  
.  
第二步：首先，放入第一步所做的架構。填寫component名稱，及要依附的gameobject名稱。  
.  
第三步：填寫外部資料，會因怪物不同而變的資料，像是prefab名稱，數值及動畫。  
注意！可以看到有個叫做TypeName的欄位，寫下它要注入的型態，譬如，animator 的Controller它所需的類別是 RuntimeAnimatorController，而平常在AssetMenu所創造的是AnimatorController類，它繼承RuntimeAnimatorController，所以請在底下補充一下Component所需要的類別。如果該類別本身就是Component所需的，則不需要填寫，空著即可。  
.  
第四步：將OutsideDataArchitecture(常變動的資料)及BodyArchitecture(主體，或著說不常變動資料)放入Combiner。最後按下Create就大功告成啦！  
.  
請放心！這些資料都會自動注入，所以完全不用再進入prefab裡把零件拖來拖去的。  
.  
.  
最後，有寫個Tag，方便注入gameObject，因為架構裡會有很多gameObject，我不曉得要注入哪個到你的程式裡。所以請參考下圖，它只會找架構裡有的gameObject喔！  
.  
.  
以後會繼續更新，畢竟功能上還沒有很全面，但應該也夠用了！如果覺得不錯用！可以留言鼓勵我哈哈哈！  
