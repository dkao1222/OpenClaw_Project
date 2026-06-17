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
