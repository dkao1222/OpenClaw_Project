# Progression and Rewards Draft

## Game Quality Alignment

- Business design must protect first-run clarity, playable retry, readable failure, and human QA evidence before monetization pressure.

## Product Experience Alignment

- Product experience cards read: FIRST_RUN_CLARITY.md, FEEDBACK_AND_GAME_FEEL.md, HUMAN_VISUAL_QA_GATES.md; business rules cannot override human playability.

## Game System Design Alignment

- Business and reward decisions must map to runtime fields, QA evidence, and downstream owner acceptance instead of abstract retention claims.

## 繁體中文

### 範圍
- Progression and Rewards Draft 只定義 MVP 可承受的輕量進度，不加入帳號、商城、gacha、IAP、長期任務或 liveops calendar。
- MVP progression 來源是 Best score、combo peak、clean drift streak、boost pickup count、hazard wave survived；所有進度都必須由 gameplay skill 觸發，不可只因等待時間自然增加。
- Reward taxonomy：instant reward 是 score/combo/pulse feedback；session reward 是 Best score 或 new record；future reward 是 cosmetic color、daily challenge、optional rewarded revive，但 future reward 不進本輪開發範圍。
- Retention hooks：失敗畫面顯示 final score、best、combo peak、failure reason、Retry；若未來加入 daily objective，必須是短局可完成，不得要求登入或長時間 grind。
- QA acceptance：錄影需證明 reward 與 player action 有因果關係；runtime/event evidence 需包含 score_delta_reason、combo_count、pickup_count、hazard_count、best_score_updated、last_failure_reason。

### 決策
- 本文件不新增帳號、商城、gacha、IAP 或 production ads；所有商業/進度設計必須保持 first-run 可玩性與 retry 可用性。

### 交接重點
- Spec Review 需核對 rewarded ads、retention loop、event fields、privacy/ATT、QA acceptance；Development 只能實作已轉成 runtime evidence 的項目。

## English

### Scope
- Progression and Rewards Draft defines only lightweight MVP progression; accounts, shop, gacha, IAP, long missions, and liveops calendar are out of scope.
- MVP progression comes from Best score, combo peak, clean drift streak, boost pickup count, and hazard wave survived; every progression signal must come from gameplay skill rather than passive waiting.
- Reward taxonomy: instant reward is score/combo/pulse feedback; session reward is Best score or new record; future reward is cosmetic color, daily challenge, or optional rewarded revive, but future rewards are outside the current build scope.
- Retention hooks: failure screen shows final score, best, combo peak, failure reason, and Retry; any future daily objective must be short-session friendly and must not require login or long grind.
- QA acceptance: video must prove reward is caused by player action; runtime/event evidence includes score_delta_reason, combo_count, pickup_count, hazard_count, best_score_updated, and last_failure_reason.

### Decisions
- This file does not add accounts, shop, gacha, IAP, or production ads; all business/progression design must preserve first-run playability and usable retry.

### Handoff Notes
- Spec Review verifies rewarded ads, retention loop, event fields, privacy/ATT, and QA acceptance; Development only implements items translated into runtime evidence.
