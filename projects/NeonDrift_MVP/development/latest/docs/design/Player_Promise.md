# Player Promise

## 繁體中文

### 玩家承諾
- 每一場短局都要快速、可讀，並讓玩家覺得值得立刻再挑戰一次。
- 玩家應能在失敗後理解原因，並知道下一輪可以改善的操作。

### 核心輸入承諾
- 轉向、加速與重新開始都必須即時、穩定且結果可預期。
- 操作失敗應回到玩家決策，而不是隱藏延遲或不清楚的物理規則。

### MVP 體感
- 聚焦速度感、公平壓力、明確進步，以及失敗後能快速回到下一局。
- MVP 不追求大量內容，優先驗證短局循環是否值得重玩。

## English

### Player Promise
- Every short run feels fast, readable, and worth retrying immediately.
- After failure, the player understands the cause and what to improve next.

### Core Input Promise
- Steering, boost, and restart must respond immediately, consistently, and predictably.
- Failure should map to player decisions rather than hidden latency or unclear physics.

### MVP Feeling
- The MVP emphasizes speed, fair pressure, visible progress, and fast recovery after failure.
- It does not chase content volume; it validates whether the short-run loop is replayable.

## Reasoning and Tradeoffs

- selected approach: promise an understandable one-hand mobile run with immediate feedback, clear failure, and fast retry.
- rejected alternatives: promise broad modes, character collection, long-term economy, or advanced skill systems before the base loop is proven.
- why selected: player trust comes from knowing what happened after every touch and why the run ended.
- acceptance evidence: QA must record Start, touch input response, score/risk change, failure explanation, Retry, and a fresh second run.
- risks if wrong: if the player cannot explain what to do in the first run, richer effects or more levels only add noise.
- downstream owner: ui-ux-designer owns first-run comprehension; game-designer owns loop depth; build and QA own touch/simulator evidence.
- source_paths: docs/planning/One_Page_Game_Concept.md, docs/product/MVP_PRD.md, status/context/stage02_context_pack.md.
