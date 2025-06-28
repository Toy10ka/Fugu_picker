# 🐡 Fugu_picker

制限時間内にプール内にいる6匹のフグ（Puffer Fish）をすべて集めるタイムアタックゲームです。

![](Images/screenshot_gameplay.png) 

---

## 🎮 遊び方 / How to Play
矢印キーでプレイヤーボールを転がします。
制限時間以内に、壁にぶつからないようにすべてのフグを集めることができればクリアです。
- 残り時間が **5 秒以下** になるとタイマーが赤⇔白で点滅します。  
- フグをすべて集めると **Game Clear!**、タイムアップまたは壁に衝突すると **Game Over…** が表示されます。

---

## 📂 プロジェクト構成
```text
├─ Assets/
│ ├─ Scenes/ … GameScene.unity
│ ├─ Scripts/ … ゲームロジック (C#)
│ ├─ Prefab/ … フグのプレハブ
│ ├─ Materials/ … 壁等のマテリアル
│ └─ _Art/ … フグの自作3DModel，texture, materials
├─ ProjectSettings/
├─ Packages/
└─ README.md … このファイル
```
---

## ⚙️ 開発環境 / Requirements

Unity 6.0 (6000.0.50f1) 

---

##　📝 今後の TODO / Ideas
- 難易度選択に応じた制限時間

- フグのスポーン位置をランダム化

- モバイル操作対応（ジャイロ + タッチ UI）

- 毒を持ったフグなどのギミック

- サウンドの実装



 
