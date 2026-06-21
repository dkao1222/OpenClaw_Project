# Prototype Flow

## 繁體中文

required keywords: prototype flow, transition, start, run, failure, restart, canvas artifact

- prototype flow 從 Start Run 進入 run，依序展示 Drift、Boost、Crash、Retry 五個感受節點。
- transition 必須呈現操作節奏：start settle 0.5s、steering response 80ms、pause freeze 100ms、retry return 0.3s。
- run state 保持 HUD 可見，並同步更新 score、speed、danger feedback、camera response 與 haptics cue。
- failure state 必須說明 crash reason，並用 Retry 作為最強主要 action。
- canvas artifact: docs/design/Prototype_Flow_Canvas.html 用 HTML canvas 表達操作感受與狀態節奏。

## English

required keywords: prototype flow, transition, start, run, failure, restart, canvas artifact

- prototype flow moves from Start Run into run, then demonstrates five feel nodes: Drift, Boost, Crash, and Retry.
- transition timing must communicate feel: start settle 0.5s, steering response 80ms, pause freeze 100ms, retry return 0.3s.
- run state keeps HUD visible while score, speed, danger feedback, camera response, and haptics cue update together.
- failure state names the crash reason and gives Retry the strongest primary-action weight.
- canvas artifact: docs/design/Prototype_Flow_Canvas.html uses HTML canvas to communicate input feel and state rhythm.

## Apple HIG Alignment

- HIG cards read: ROUTING.md, CORE_PRINCIPLES.md, GAME_UI_CHECKLIST.md, ACCESSIBILITY_LOCALIZATION.md, VALIDATION_GATES.md.
- platform assumptions: iPhone-first Unity game UI with later Android/WebGL adaptation; safe area avoids notch, Dynamic Island, and home indicator.
- alignment decisions: preserve clarity for HUD/readability, defer decoration behind gameplay content, keep restart under user control, and support reduced motion/readable contrast.
- accessibility: every icon/action needs a semantic label, visible state, 44x44 pt touch target when touch is used, and non-motion fallback for critical feedback.
- intentional deviations: fast neon motion and camera shake are allowed only when lane, hazard, HUD, and failure reason remain readable.
- open questions: final orientation, device tier floor, and exact haptics availability require confirmation during development QA.
