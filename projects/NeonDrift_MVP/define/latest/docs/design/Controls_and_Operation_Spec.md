# Controls and Operation Spec

## 繁體中文

required keywords: controls, touch, left, right, tap, hold, steering, pause, restart, feedback, 44x44, iOS simulator

- controls: 玩家使用 touch zones 進行 steering、pause 與 restart；iOS simulator click 必須走相同 touch path。
- touch: 左右下角 touch zones 是主要操作，所有 touch targets 至少 44x44 pt 並避開 safe area。
- left/right: Left zone 讓車輛往左漂移，Right zone 讓車輛往右漂移，兩者不得遮蔽中央 racing lane。
- tap/hold: tap 產生短 drift impulse，hold 維持 drift pressure，放開後回到中性狀態。
- steering: 左右 touch input 必須在 80ms 內更新移動、trail、HUD feedback。
- pause/restart: pause 與 failure 狀態都要提供清楚的 restart/retry touch action。
- feedback: HUD、動畫、audio/haptics cue 要確認每個重要 touch input。

## Reasoning and Tradeoffs

- selected approach: iOS touch-first left/right zones with tap/hold behavior and simulator clicks mapped to touch.
- rejected alternatives: desktop key input as primary control, tiny on-screen icons, and swipe-only steering are rejected for first-run clarity.
- why selected: the product is iOS-first, so QA evidence must prove real touch targets and immediate feedback, not desktop convenience.
- acceptance evidence: QA video must show Start, Left touch, Right touch, Pause, Retry, and visible feedback after each input.

## English

required keywords: controls, touch, left, right, tap, hold, steering, pause, restart, feedback, 44x44, iOS simulator

- controls: player uses touch zones for steering, pause, and restart; iOS simulator clicks must follow the same touch path.
- touch: bottom left/right touch zones are primary controls, with every touch target at least 44x44 pt and outside unsafe areas.
- left/right: Left zone drifts left, Right zone drifts right, and neither may cover the central racing lane.
- tap/hold: tap creates a short drift impulse, hold maintains drift pressure, and release returns to neutral.
- steering: left and right touch input must update movement, trail, and HUD feedback within 80ms.
- pause/restart: pause and failure states both provide clear restart/retry touch actions.
- feedback: HUD, animation, and audio/haptics cue confirm every important touch input.

## Reasoning and Tradeoffs

- selected approach: iOS touch-first left/right zones with tap/hold behavior and simulator clicks mapped to touch.
- rejected alternatives: desktop key input as primary control, tiny on-screen icons, and swipe-only steering are rejected for first-run clarity.
- why selected: the product is iOS-first, so QA evidence must prove real touch targets and immediate feedback, not desktop convenience.
- acceptance evidence: QA video must show Start, Left touch, Right touch, Pause, Retry, and visible feedback after each input.
## Apple HIG Alignment

- HIG cards read: ROUTING.md, CORE_PRINCIPLES.md, GAME_UI_CHECKLIST.md, ACCESSIBILITY_LOCALIZATION.md, VALIDATION_GATES.md.
- platform assumptions: iPhone-first Unity game UI with later Android/WebGL adaptation; safe area avoids notch, Dynamic Island, and home indicator.
- alignment decisions: preserve clarity for HUD/readability, defer decoration behind gameplay content, keep restart under user control, and support reduced motion/readable contrast.
- accessibility: every icon/action needs a semantic label, visible state, 44x44 pt touch target when touch is used, and non-motion fallback for critical feedback.
- intentional deviations: fast neon motion and camera shake are allowed only when lane, hazard, HUD, and failure reason remain readable.
- open questions: final orientation, device tier floor, and exact haptics availability require confirmation during development QA.
