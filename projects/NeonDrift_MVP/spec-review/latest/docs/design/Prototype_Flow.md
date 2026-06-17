# Prototype Flow

## 繁體中文

required keywords: prototype flow, transition, start, run, failure, restart

- prototype flow 從 start 開始，進入 run，並分支到 pause 或 failure。
- start 到 run 的 transition 在主要 action 後立即發生。
- run state 保持 HUD 可見，並更新 score、speed 與 danger feedback。
- failure state 說明 crash reason，並以 restart 作為主要 action。
- restart 直接把玩家帶回新的 run。

## English

required keywords: prototype flow, transition, start, run, failure, restart

- prototype flow begins at start, moves to run, and branches into pause or failure.
- transition from start to run is immediate after the primary action.
- run state keeps the HUD visible and updates score, speed, and danger feedback.
- failure state explains the crash reason and offers restart as the primary action.
- restart returns the player directly to a fresh run.