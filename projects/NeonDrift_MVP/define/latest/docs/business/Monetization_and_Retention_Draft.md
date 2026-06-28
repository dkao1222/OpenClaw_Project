# Monetization and Retention Draft

## Game Quality Alignment

- Business design must protect first-run clarity, playable retry, readable failure, and human QA evidence before monetization pressure.

## Product Experience Alignment

- Product experience cards read: FIRST_RUN_CLARITY.md, FEEDBACK_AND_GAME_FEEL.md, HUMAN_VISUAL_QA_GATES.md; business rules cannot override human playability.

## Game System Design Alignment

- Business and reward decisions must map to runtime fields, QA evidence, and downstream owner acceptance instead of abstract retention claims.

## 繁體中文

### 範圍
- Monetization and Retention Draft 只定義 MVP 後續可用的商業邊界、retention loop、rewarded ads placement 與 compliance guardrail，不在目前 MVP 實作正式廣告或付費流程。
- Rewarded ads 只允許出現在 failure/retry 後的自願 revive、bonus reward 或 cosmetic preview；不得出現在 first-run learning、第一次 Start 前、教學前 10 秒、玩家尚未理解 hazard/boost/pulse 前，也不得阻斷 Retry。
- AdMob 準備項目包含 app id placeholder、ad unit placeholder、test mode、frequency cap、child/teen audience decision、ATT/IDFA policy、privacy label、consent flow、store review note；production key 不得寫入 repo。
- Retention loop 是短局 mastery：first-run clarity -> readable failure -> instant retry -> Best score/combo peak -> optional future daily challenge；核心事件欄位包含 run_started、run_failed、retry_tapped、ad_offer_shown、ad_accepted、ad_skipped、revive_used、session_length、last_failure_reason。
- QA acceptance：錄影需證明 first-run 不被 ad 打斷，failure 後可 retry，ad offer 若存在必須是可拒絕選項；runtime/event evidence 需能區分 ad skipped 與 retry tapped，且 privacy/ATT 文件不可缺席。

### 決策
- 本文件不新增帳號、商城、gacha、IAP 或 production ads；所有商業/進度設計必須保持 first-run 可玩性與 retry 可用性。

### 交接重點
- Spec Review 需核對 rewarded ads、retention loop、event fields、privacy/ATT、QA acceptance；Development 只能實作已轉成 runtime evidence 的項目。

## English

### Scope
- Monetization and Retention Draft defines only business boundaries, retention loop, rewarded ads placement, and compliance guardrails for a later MVP iteration; production ads or paid flows are not implemented in the current MVP.
- Rewarded ads are allowed only after failure/retry as voluntary revive, bonus reward, or cosmetic preview; they must not appear before first-run learning, before the first Start, during the first 10 seconds, before hazard/boost/pulse are understood, or in a way that blocks Retry.
- AdMob readiness includes app id placeholder, ad unit placeholder, test mode, frequency cap, child/teen audience decision, ATT/IDFA policy, privacy label, consent flow, and store review note; production keys must not be written to the repo.
- The retention loop is short-session mastery: first-run clarity -> readable failure -> instant retry -> Best score/combo peak -> optional future daily challenge; required event fields are run_started, run_failed, retry_tapped, ad_offer_shown, ad_accepted, ad_skipped, revive_used, session_length, and last_failure_reason.
- QA acceptance: recording must prove first-run is not interrupted by ads, failure still allows retry, and any ad offer is optional; runtime/event evidence must distinguish ad skipped from retry tapped, with privacy/ATT docs present.

### Decisions
- This file does not add accounts, shop, gacha, IAP, or production ads; all business/progression design must preserve first-run playability and usable retry.

### Handoff Notes
- Spec Review verifies rewarded ads, retention loop, event fields, privacy/ATT, and QA acceptance; Development only implements items translated into runtime evidence.
