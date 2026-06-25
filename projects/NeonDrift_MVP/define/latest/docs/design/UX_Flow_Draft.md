# UX Flow Draft

## 繁體中文

required keywords: UX flow, onboarding, HUD, controls, retry, player

- UX flow: player 進入 run、讀取 HUD status、使用 controls、安全失敗，然後選擇 retry。
- onboarding: 首局透過即時 feedback 說明 touch steering、pause 與 restart 預期。
- HUD: speed、score、danger state、retry affordance 保持可見，不遮住 racing line。
- controls: steering、boost、pause、restart 必須即時且可預期。
- retry: failure screen 以單一清楚 action 帶玩家回到新的 run。
- player: 每個 state 都要保留可讀 feedback 與繼續嘗試的信心。

## English

required keywords: UX flow, onboarding, HUD, controls, retry, player

- UX flow: player enters the run, reads HUD status, uses controls, fails safely, then chooses retry.
- onboarding: first session shows touch steering, pause, and restart expectations through immediate feedback.
- HUD: speed, score, danger state, and retry affordance stay visible without hiding the racing line.
- controls: steering, boost, pause, and restart must feel immediate and predictable.
- retry: failure screen returns the player to a new run with one clear action.
- player: every state must preserve readable feedback and confidence to continue.
## Apple HIG Alignment

- HIG cards read: ROUTING.md, CORE_PRINCIPLES.md, GAME_UI_CHECKLIST.md, ACCESSIBILITY_LOCALIZATION.md, VALIDATION_GATES.md.
- platform assumptions: iPhone-first Unity game UI with later Android/WebGL adaptation; safe area avoids notch, Dynamic Island, and home indicator.
- alignment decisions: preserve clarity for HUD/readability, defer decoration behind gameplay content, keep restart under user control, and support reduced motion/readable contrast.
- accessibility: every icon/action needs a semantic label, visible state, 44x44 pt touch target when touch is used, and non-motion fallback for critical feedback.
- intentional deviations: fast neon motion and camera shake are allowed only when lane, hazard, HUD, and failure reason remain readable.
- open questions: final orientation, device tier floor, and exact haptics availability require confirmation during development QA.
