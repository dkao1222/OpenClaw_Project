# MVP Hypothesis

## 繁體中文

### 假設
- 玩家會因為單手左右操作與立即重試而願意在短時間內多次遊玩。
- 清楚 HUD、safe area 與失敗原因會降低首次遊玩挫折，讓玩家更容易接受 rewarded ads 的後續設計。

### 驗證方式
- 以本機 iOS simulator QA 驗證 Start、Pause、Retry、分數 HUD、左右控制、安全區與 frame pacing 是否存在且可讀。
- 以首輪時長、retry 次數、失敗後返回遊戲比例與 D1 retention 作為後續產品驗證資料。

### 成功指標
- QA build 通過 0 failed / 0 blocked，且 simulator app 可安裝、啟動、截圖非空白、runtime 無 fatal exception。
- 首輪平均遊玩時間超過 30 秒，首輪後至少 50% 玩家嘗試 retry。

## English

### Hypothesis
- Players will replay multiple times in short sessions because one-handed left/right control and instant retry reduce friction.
- Readable HUD, safe area handling, and clear failure feedback reduce first-run frustration and make later rewarded-ad design more acceptable.

### Validation Method
- Use local iOS simulator QA to verify Start, Pause, Retry, score HUD, left/right controls, safe area, and frame pacing are present and readable.
- Track first-run duration, retry count, post-failure return rate, and D1 retention as later product validation signals.

### Success Metrics
- QA build passes with 0 failed / 0 blocked, and the simulator app installs, launches, renders a nonblank screenshot, and reports no fatal runtime exception.
- Average first-run duration exceeds 30 seconds, and at least 50% of first-run players try retry after failure.
