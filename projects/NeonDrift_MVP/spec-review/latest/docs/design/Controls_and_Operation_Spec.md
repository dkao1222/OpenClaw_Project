# Controls and Operation Spec

## 繁體中文

required keywords: controls, keyboard, steering, boost, restart, feedback

- controls: 玩家使用 keyboard input 進行 steering、boost、pause 與 restart。
- keyboard: 方向鍵或 WASD 在 run 中控制車輛方向。
- steering: 左右輸入必須立即更新移動結果。
- boost: boost 提升速度，並在 HUD 上提高 danger feedback。
- restart: pause 與 failure 狀態都要提供 restart。
- feedback: HUD 與動態回饋要確認每個重要 input。

## English

required keywords: controls, keyboard, steering, boost, restart, feedback

- controls: player uses keyboard input for steering, boost, pause, and restart.
- keyboard: arrow keys or WASD steer the vehicle during the run.
- steering: left and right input must update movement immediately.
- boost: boost increases speed and raises danger feedback on the HUD.
- restart: restart is available from pause and failure states.
- feedback: HUD and motion feedback confirm every important input.
## Apple HIG Alignment

- HIG cards read: ROUTING.md, CORE_PRINCIPLES.md, GAME_UI_CHECKLIST.md, ACCESSIBILITY_LOCALIZATION.md, VALIDATION_GATES.md.
- platform assumptions: iPhone-first Unity game UI with later Android/WebGL adaptation; safe area avoids notch, Dynamic Island, and home indicator.
- alignment decisions: preserve clarity for HUD/readability, defer decoration behind gameplay content, keep restart under user control, and support reduced motion/readable contrast.
- accessibility: every icon/action needs a semantic label, visible state, 44x44 pt touch target when touch is used, and non-motion fallback for critical feedback.
- intentional deviations: fast neon motion and camera shake are allowed only when lane, hazard, HUD, and failure reason remain readable.
- open questions: final orientation, device tier floor, and exact haptics availability require confirmation during development QA.
