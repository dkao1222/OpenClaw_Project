# Player Interaction Model

## 繁體中文

### 輸入模型
- iOS MVP 使用左右兩個大觸控區，支援 tap 與 hold；tap 產生短漂移修正，hold 產生持續 drift force，放開後車體回正。
- 按鍵尺寸、位置與 safe area 必須適合 iPhone SE 到 iPhone Pro Max，且不遮擋主要賽道與 failure/retry 彈窗。

### 玩家可感知回饋
- 每次輸入都要有至少兩種回饋：按鍵狀態變化、車體位移、軌跡亮度、短音效、haptic 或 HUD pulse 變化。
- 玩家按下 Start 後若 2 秒內看不到可操作物件或移動變化，QA 應判定互動失敗。

### 互動驗收
- QA 需錄影驗證 Start、Retry、Pause、Left、Right、Settings/Sound toggle；每個功能要有前後狀態差異，而不是只有按鈕被點擊。
- 對遊戲功能的驗收包含：敵人/障礙接近、玩家可躲避、boost 可收集、score 會變、失敗原因可理解、retry 後 gameplay 重新動起來，且 game-over 到 after-retry 的視覺差異足以被影片判讀。

## English

### Input Model
- The iOS MVP uses two large left/right touch zones supporting tap and hold; tap creates a short drift correction, hold applies sustained drift force, and release recenters the vehicle.
- Button size, placement, and safe area must work from iPhone SE to iPhone Pro Max without hiding the main track or failure/retry modal.

### Perceptible Feedback
- Every input needs at least two feedback types: button state change, vehicle displacement, trail brightness, short sound, haptic, or HUD pulse change.
- If the player presses Start and cannot see an operable object or motion change within 2 seconds, QA must mark interaction failed.

### Interaction Acceptance
- QA must record Start, Retry, Pause, Left, Right, and Settings/Sound toggle; every function needs a before/after state difference, not only a clicked button.
- Gameplay acceptance includes approaching enemies/hazards, player avoidance, collectible boost, changing score, understandable failure cause, gameplay restarting after retry, and a video-readable visual difference between game-over and after-retry frames.
