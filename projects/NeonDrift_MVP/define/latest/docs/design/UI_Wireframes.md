# UI Wireframes

## 繁體中文

required keywords: wireframe, HUD, safe area, main run, pause, failure

### main run wireframe
- 全螢幕 playfield 保留中央 safe area，確保 racing line 清楚可讀。
- HUD 固定在上緣，不遮擋主要 driving lane。

### HUD
- 左上角顯示 score 與 speed。
- 右上角顯示 boost state 與 danger feedback。
- 下方中央只在 failure 或 pause 後顯示 restart hint。

### pause
- 中央 pause panel 提供 Resume、Restart、Exit actions。
- 背景降低亮度，但最後的 run state 仍需可讀。

### failure/retry
- failure state 顯示 crash reason、final score 與主要 Retry action。
- retry 直接回到 main run screen。

### safe area and button positions
- HUD 與 buttons 必須避開中央 driving safe area。
- pause button 放在右上角；failure 時 retry button 放在中下區域。

## English

required keywords: wireframe, HUD, safe area, main run, pause, failure

### main run wireframe
- full screen playfield with the racing line kept clear in the center safe area.
- HUD stays pinned to the top edge and never covers the primary driving lane.

### HUD
- top left: score and speed.
- top right: boost state and danger feedback.
- bottom center: restart hint only after failure or pause.

### pause
- centered pause panel with Resume, Restart, and Exit actions.
- background is dimmed but the last run state remains readable.

### failure/retry
- failure state shows the crash reason, final score, and one primary Retry action.
- retry returns directly to the main run screen.

### safe area and button positions
- keep HUD and buttons outside the center driving safe area.
- pause button sits top right; retry button sits center lower third on failure.
## Apple HIG Alignment

- HIG cards read: ROUTING.md, CORE_PRINCIPLES.md, GAME_UI_CHECKLIST.md, ACCESSIBILITY_LOCALIZATION.md, VALIDATION_GATES.md.
- platform assumptions: iPhone-first Unity game UI with later Android/WebGL adaptation; safe area avoids notch, Dynamic Island, and home indicator.
- alignment decisions: preserve clarity for HUD/readability, defer decoration behind gameplay content, keep restart under user control, and support reduced motion/readable contrast.
- accessibility: every icon/action needs a semantic label, visible state, 44x44 pt touch target when touch is used, and non-motion fallback for critical feedback.
- intentional deviations: fast neon motion and camera shake are allowed only when lane, hazard, HUD, and failure reason remain readable.
- open questions: final orientation, device tier floor, and exact haptics availability require confirmation during development QA.
