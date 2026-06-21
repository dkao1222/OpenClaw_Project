# Failure Retry System Spec

Document contract: this file records only the current stage decision surface for the next planning owner. Do not add sections, do not copy full prior documents, and keep each subsection to 1 bullet.

## 繁體中文

required keywords: failure, retry, system, spec

### 範圍
- Failure/Retry System 只負責碰撞或離線後的狀態轉換、失敗原因、結果畫面與 retry 入口。

### 決策
- 失敗後必須停止輸入、顯示 final score/best score/reason，Retry 是主要操作並直接回到新 run。

### 交接重點
- 驗收標準是從 crash 到可按 Retry 的時間短且穩定，玩家不需要回主選單才能重新開始。

## English

required keywords: failure, retry, system, spec

### Scope
- The Failure/Retry System owns state transition after collision or off-line failure, failure reason, result screen, and retry entry.

### Decisions
- After failure it must stop input, show final score, best score, and reason; Retry is the primary action and returns directly to a new run.

### Handoff Notes
- Acceptance requires a short and stable time from crash to actionable Retry, without forcing the player back to the main menu.
