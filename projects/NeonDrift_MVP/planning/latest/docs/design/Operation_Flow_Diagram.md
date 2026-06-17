# Operation Flow Diagram

## 繁體中文

required keywords: operation flow, input, feedback, screen flow, fail, retry

### operation flow
- Start Run 進入 0.5 秒 camera settle，HUD 淡入，玩家看到 racing line 與第一個 hazard preview。
- Run 中每個 input 都要形成 player intent -> system response -> sensory feedback -> state transition 的閉環。
- 操作感目標是 responsive but risky：轉向立即、boost 有速度壓力、失敗原因清楚、retry 不打斷節奏。

### input to feedback
- latency target: steering 在 80ms 內回應、pause 在 100ms 內凍結、retry 在 0.3s 內回到新局。
- camera response: steering 時輕微跟隨、boost 時增加速度線、failure 時短 camera bump，但不得遮擋 racing line。
- steering input: 左/右按下後 80ms 內車體偏移與 drift trail 出現，camera 輕微跟隨但不遮擋 racing line。
- boost input: 立即提高 speed state、HUD danger pulse、速度線加強；feel target 是爽快但可讀，不能讓 hazard 瞬間不可判讀。
- pause input: 100ms 內凍結 run state、降低背景亮度、顯示 Resume/Restart/Exit；不得誤觸 retry。
- failure input/state: collision 或 off-line 後觸發 red edge flash、短 haptics、camera bump 與 crash reason。

### screen flow
- start screen -> main run: primary Start action 後直接進入 playable state。
- main run -> pause: 保留最後畫面作為 context，避免玩家失去位置感。
- main run -> failure: 顯示 crash reason、final score、best score、Retry primary action。
- failure -> retry -> main run: retry 清空 failed state，0.3 秒內回到新局。

### fail and retry path
- fail 必須指出具體原因：hit hazard、left racing line、boost over-risk；不能只有 Game Over。
- retry 必須是最強視覺權重，玩家不用回主選單即可再玩。

## English

required keywords: operation flow, input, feedback, screen flow, fail, retry

### operation flow
- Start Run enters a 0.5s camera settle, fades in the HUD, and reveals the racing line plus the first hazard preview.
- During run, every input must close the loop: player intent -> system response -> sensory feedback -> state transition.
- The feel target is responsive but risky: steering is immediate, boost adds pressure, failure is explainable, and retry preserves momentum.

### input to feedback
- latency target: steering responds within 80ms, pause freezes within 100ms, and retry returns to a fresh run within 0.3s.
- camera response: steering follows lightly, boost adds speed lines, and failure adds a short camera bump without hiding the racing line.
- steering input: within 80ms, the vehicle shifts and drift trail appears; camera follows lightly without hiding the racing line.
- boost input: speed state rises immediately, HUD danger pulses, and speed lines intensify; feel target is fast but still readable.
- pause input: within 100ms, run state freezes, background dims, and Resume/Restart/Exit appears; retry cannot be triggered accidentally.
- failure input/state: collision or off-line state triggers red edge flash, short haptics, camera bump, and crash reason.

### screen flow
- start screen -> main run: primary Start action enters playable state directly.
- main run -> pause: preserves the last frame as context so the player keeps spatial memory.
- main run -> failure: shows crash reason, final score, best score, and Retry primary action.
- failure -> retry -> main run: retry clears failed state and starts a fresh run within 0.3s.

### fail and retry path
- fail must name the reason: hit hazard, left racing line, or boost over-risk; Game Over alone is not acceptable.
- retry has the strongest visual weight and lets the player replay without returning to the main menu.