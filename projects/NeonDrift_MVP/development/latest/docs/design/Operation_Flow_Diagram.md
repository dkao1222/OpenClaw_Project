# Operation Flow Diagram

## 繁體中文

required keywords: operation flow, input, feedback, screen flow, fail, retry

### operation flow
- 玩家開始短局、沿賽道線前進、避開危險，並透過存活與技巧累積分數。
- 每個 input 都要立刻產生 feedback，讓玩家理解速度、轉向、boost 與 danger 狀態。

### input to feedback
- keyboard steering 會立刻改變車輛方向，並給出可見的移動 feedback。
- boost 提高速度，同時更新 HUD feedback 並提高風險。
- pause 會停止當前 run，並顯示 resume、restart、exit 選項。

### screen flow
- start screen 會轉入 main run。
- main run 可轉入 pause、failure 或 retry。
- failure 會轉入 retry，再回到 main run。

### fail and retry path
- fail state 顯示撞擊原因、最終分數與 retry 行動。
- retry 清除失敗局狀態，並立即開始新的 main run。

## English

required keywords: operation flow, input, feedback, screen flow, fail, retry

### operation flow
- player starts a run, follows the racing line, avoids hazards, and builds score through survival.
- each input produces immediate feedback so the player understands speed, steering, boost, and danger.

### input to feedback
- keyboard steering changes vehicle direction with visible movement feedback.
- boost increases speed and updates HUD feedback while raising risk.
- pause stops the run and exposes resume, restart, and exit choices.

### screen flow
- start screen transitions to main run.
- main run transitions to pause, failure, or retry.
- failure transitions to retry, then back to main run.

### fail and retry path
- fail state shows crash reason, final score, and retry action.
- retry clears the failed run state and starts a new main run immediately.