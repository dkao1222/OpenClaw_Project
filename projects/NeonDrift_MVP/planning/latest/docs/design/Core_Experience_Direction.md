# Core Experience Direction

## 繁體中文

### 情緒目標
- 玩家每一局都要感到高速、清楚、可掌控，而不是被混亂視覺壓倒。
- 失敗要帶來立即再試一次的衝動，並讓玩家知道下一次可以改善什麼。

### 互動意圖
- 核心互動聚焦短局漂移、避障、得分與快速重試。
- 所有回饋都必須支援玩家判斷路線、風險與操作時機。

### 核心輸入承諾
- 轉向、漂移、加速與重開必須即時、穩定且可預期。
- 操作失敗應回到玩家決策，而不是不清楚的延遲或隱藏規則。

### 流程範圍
- MVP 流程包含開始、進行中、得分、失敗與快速重試。
- 不包含多人、帳號、長期任務或複雜車輛養成。

### 體驗邊界
- 視覺特效不可遮蔽賽道、危險物、得分或狀態資訊。
- 介面必須優先支援短時間掃讀與重複遊玩。

## English

### Emotional Target
- Each run should feel fast, readable, and controllable rather than visually chaotic.
- Failure should create an immediate retry impulse and show what can improve next.

### Interaction Intent
- Core interaction focuses on short-run drifting, hazard avoidance, scoring, and quick retry.
- All feedback must support route reading, risk judgment, and input timing.

### Core Input Promise
- Steering, drift, boost, and restart must feel immediate, stable, and predictable.
- Failure should trace back to player choices, not unclear latency or hidden rules.

### Operation Flow Scope
- MVP flow includes start, active run, scoring, failure, and fast retry.
- It excludes multiplayer, accounts, long quests, and complex vehicle progression.

### Experience Boundaries
- Visual effects must not hide the lane, hazards, score, or state information.
- UI must prioritize quick scanning and repeated play sessions.

## Reasoning and Tradeoffs

- selected approach: lock a short-session, touch-first drift loop before adding meta progression or content volume.
- rejected alternatives: full racing simulation, deep garage upgrade, multiplayer race, and story mission structure are rejected for MVP scope.
- why selected: Stage 02 positions the product around quick mobile replay, so the first playable arc must prove readability, control trust, and retry motivation.
- acceptance evidence: QA must capture Start -> first input -> visible drift response -> score/risk feedback -> failure reason -> Retry in screenshot or video.
- risks if wrong: if speed hides hazards or failure feels unexplained, later content depth cannot rescue the core loop.
- downstream owner: ui-ux-designer owns operation clarity; game-designer owns rules and challenge pacing; QA owns video proof.
- source_paths: docs/planning/Game_Proposal.md, docs/planning/One_Page_Game_Concept.md, docs/product/MVP_PRD.md, status/context/stage02_context_pack.md.
