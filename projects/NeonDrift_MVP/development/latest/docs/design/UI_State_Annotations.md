# UI State Annotations

## 繁體中文

required keywords: state, default, active, disabled, feedback, transition

- state: 每個畫面都定義 default、active、disabled、feedback 與 transition 行為。
- default: main run 顯示可操作 HUD、中央 racing lane 與正常 control response。
- active: steering、boost、pause、retry 都要提供即時 visual feedback。
- disabled: 不可用 actions 降低視覺權重，且不可搶走焦點。
- feedback: danger、failure、scoring 變化必須可讀，且不遮擋 lane。
- transition: start、pause、failure、restart transitions 必須直接且可預期。

## English

required keywords: state, default, active, disabled, feedback, transition

- state: every screen has default, active, disabled, feedback, and transition behavior.
- default: main run shows playable HUD, centered racing lane, and normal control response.
- active: steering, boost, pause, and retry show immediate visual feedback.
- disabled: unavailable actions are muted and cannot steal focus.
- feedback: danger, failure, and scoring changes are readable without covering the lane.
- transition: start, pause, failure, and restart transitions are direct and predictable.
## Apple HIG Alignment

- HIG cards read: ROUTING.md, CORE_PRINCIPLES.md, GAME_UI_CHECKLIST.md, ACCESSIBILITY_LOCALIZATION.md, VALIDATION_GATES.md.
- platform assumptions: iPhone-first Unity game UI with later Android/WebGL adaptation; safe area avoids notch, Dynamic Island, and home indicator.
- alignment decisions: preserve clarity for HUD/readability, defer decoration behind gameplay content, keep restart under user control, and support reduced motion/readable contrast.
- accessibility: every icon/action needs a semantic label, visible state, 44x44 pt touch target when touch is used, and non-motion fallback for critical feedback.
- intentional deviations: fast neon motion and camera shake are allowed only when lane, hazard, HUD, and failure reason remain readable.
- open questions: final orientation, device tier floor, and exact haptics availability require confirmation during development QA.
