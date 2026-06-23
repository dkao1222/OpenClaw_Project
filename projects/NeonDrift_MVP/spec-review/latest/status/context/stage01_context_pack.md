# Stage 01 Context Pack

project_name: NeonDrift_MVP
channel_id: 382b9e3384298039b171c9b2a60ae644

## project goal

建立一個可在 iOS simulator 本機 build 並可 QA 驗證的 NeonDrift MVP，驗證 OpenClaw 可以把手機端/Notion 的需求轉成規劃、規格、Unity 專案、build、QA 與交付證據。

## target audience

喜歡短局、單手操作、霓虹視覺、快速重試 arcade 遊戲的手機玩家；也服務於需要快速驗證 game pipeline 的獨立開發者。

## core value

1. 一眼能懂的 drift 操作與立即重試。 2. 有視覺層次、特效、音效/震動與清楚 HUD 的短局體驗。 3. 全流程可追蹤：Notion、Git、Unity build、QA evidence 與 delivery manifest。

## locked decisions

- Notion watcher controls pipeline progression.
- Each downstream OpenClaw agent uses its configured model.
- Unity 6000.0.77f1 mobile direction is locked for planning.

## open questions

- Confirm final device compatibility and store policy details in downstream stages.

## next stage input policy

Read the Stage 01 handoff first, then this context pack. Open source paths only if details are missing.

## source paths

- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/context/Initial_Request.md
- status/context/Project_Context_Index.md
- status/context/Current_Status_Summary.md
